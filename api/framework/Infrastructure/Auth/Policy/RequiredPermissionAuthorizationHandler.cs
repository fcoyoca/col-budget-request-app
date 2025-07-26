using System.Security.Claims;
using FSH.Framework.Core.Identity.Roles;
using FSH.Framework.Core.Identity.Users.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace FSH.Framework.Infrastructure.Auth.Policy;

public sealed class RequiredPermissionAuthorizationHandler : AuthorizationHandler<PermissionAuthorizationRequirement>
{
    private readonly ILogger<RequiredPermissionAuthorizationHandler> _logger;

    public RequiredPermissionAuthorizationHandler(ILogger<RequiredPermissionAuthorizationHandler> logger)
    {
        _logger = logger;
    }

    protected override async Task HandleRequirementAsync(AuthorizationHandlerContext context, PermissionAuthorizationRequirement requirement)
    {
        var authResult = await ValidateAuthorizationAsync(context);

        if (!authResult.IsSuccess)
        {
            _logger.LogWarning("Authorization failed: {Reason}", authResult.FailureReason);
            context.Fail(new AuthorizationFailureReason(this, authResult.FailureReason));
            return;
        }

        _logger.LogDebug("User {UserId} authorized successfully with permissions: {Permissions}",
            authResult.UserId, string.Join(", ", authResult.UserPermissions));

        context.Succeed(requirement);
    }

    private async Task<AuthorizationResult> ValidateAuthorizationAsync(AuthorizationHandlerContext context)
    {
        // Step 1: Validate user authentication
        var userValidation = ValidateUserAuthentication(context);
        if (!userValidation.IsSuccess)
            return userValidation;

        // Step 2: Extract and validate required permissions from endpoint
        var permissionValidation = ExtractRequiredPermissions(context);
        if (!permissionValidation.IsSuccess)
            return permissionValidation;

        // Step 3: Extract user ID from claims
        var userIdValidation = ExtractUserId(context);
        if (!userIdValidation.IsSuccess)
            return userIdValidation;

        // Step 4: Get services from DI container
        var servicesValidation = GetRequiredServices(context);
        if (!servicesValidation.IsSuccess)
            return servicesValidation;

        // Step 5: Get user permissions from roles
        var userPermissions = await GetUserPermissionsAsync(context, servicesValidation.RoleService);
        if (!userPermissions.IsSuccess)
            return userPermissions;

        // Step 6: Check if user has required permissions
        return ValidateUserPermissions(permissionValidation.RequiredPermissions, userPermissions.UserPermissions, userIdValidation.UserId);
    }

    private static AuthorizationResult ValidateUserAuthentication(AuthorizationHandlerContext context)
    {
        if (!context.User.Identity?.IsAuthenticated ?? true)
        {
            return AuthorizationResult.Failure("User is not authenticated");
        }

        var roles = context.User.FindAll(ClaimTypes.Role).Select(r => r.Value).ToList();
        if (!roles.Any())
        {
            return AuthorizationResult.Failure("User has no roles assigned");
        }

        return AuthorizationResult.Success();
    }

    private static AuthorizationResult ExtractRequiredPermissions(AuthorizationHandlerContext context)
    {
        var endpoint = context.Resource switch
        {
            HttpContext httpContext => httpContext.GetEndpoint(),
            Endpoint ep => ep,
            _ => null,
        };

        var requiredPermissions = endpoint?.Metadata.GetMetadata<IRequiredPermissionMetadata>()?.RequiredPermissions;

        if (requiredPermissions is null || requiredPermissions.Count == 0)
        {
            return AuthorizationResult.Failure("No permissions required for this endpoint");
        }

        return AuthorizationResult.Success(requiredPermissions: requiredPermissions);
    }

    private static AuthorizationResult ExtractUserId(AuthorizationHandlerContext context)
    {
        var userId = context.User?.FindFirst(ClaimTypes.NameIdentifier)?.Value
                    ?? context.User?.FindFirst("oid")?.Value; // Azure AD uses 'oid' for user ID

        if (string.IsNullOrEmpty(userId))
        {
            return AuthorizationResult.Failure("User ID not found in claims");
        }

        return AuthorizationResult.Success(userId: userId);
    }

    private static AuthorizationResult GetRequiredServices(AuthorizationHandlerContext context)
    {
        if (context.Resource is not HttpContext httpContext)
        {
            return AuthorizationResult.Failure("HttpContext not available");
        }

        var userService = httpContext.RequestServices.GetService<IUserService>();
        var roleService = httpContext.RequestServices.GetService<IRoleService>();

        if (userService == null)
        {
            return AuthorizationResult.Failure("User service not available");
        }

        if (roleService == null)
        {
            return AuthorizationResult.Failure("Role service not available");
        }

        return AuthorizationResult.Success(userService: userService, roleService: roleService);
    }

    private static async Task<AuthorizationResult> GetUserPermissionsAsync(AuthorizationHandlerContext context, IRoleService roleService)
    {
        var roles = context.User.FindAll(ClaimTypes.Role).Select(r => r.Value).ToList();
        var allPermissions = new List<string>();

        try
        {
            foreach (var role in roles)
            {
                var roleDto = await roleService.GetWithPermissionsAsyncByRoleName(role, CancellationToken.None);
                if (roleDto?.Permissions != null)
                {
                    allPermissions.AddRange(roleDto.Permissions);
                }
            }

            var distinctPermissions = allPermissions.Distinct().ToList();
            return AuthorizationResult.Success(userPermissions: distinctPermissions);
        }
        catch (Exception ex)
        {
            return AuthorizationResult.Failure($"Failed to retrieve user permissions: {ex.Message}");
        }
    }

    private static AuthorizationResult ValidateUserPermissions(HashSet<string> requiredPermissions, List<string> userPermissions, string userId)
    {
        var missingPermissions = requiredPermissions.Where(required => !userPermissions.Contains(required)).ToList();

        if (missingPermissions.Any())
        {
            return AuthorizationResult.Failure($"User {userId} missing required permissions: {string.Join(", ", missingPermissions)}");
        }

        return AuthorizationResult.Success(userId: userId, userPermissions: userPermissions);
    }
}
