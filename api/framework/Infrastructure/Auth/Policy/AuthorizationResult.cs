using FSH.Framework.Core.Identity.Roles;
using FSH.Framework.Core.Identity.Users.Abstractions;

namespace FSH.Framework.Infrastructure.Auth.Policy;

/// <summary>
/// Represents the result of an authorization validation step.
/// </summary>
internal sealed class AuthorizationResult
{
    public bool IsSuccess { get; private init; }
    public string FailureReason { get; private init; } = string.Empty;
    public string UserId { get; private init; } = string.Empty;
    public HashSet<string> RequiredPermissions { get; private init; } = new();
    public List<string> UserPermissions { get; private init; } = new();
    public IUserService? UserService { get; private init; }
    public IRoleService? RoleService { get; private init; }

    private AuthorizationResult() { }

    /// <summary>
    /// Creates a successful authorization result.
    /// </summary>
    public static AuthorizationResult Success(
        string? userId = null,
        HashSet<string>? requiredPermissions = null,
        List<string>? userPermissions = null,
        IUserService? userService = null,
        IRoleService? roleService = null)
    {
        return new AuthorizationResult
        {
            IsSuccess = true,
            UserId = userId ?? string.Empty,
            RequiredPermissions = requiredPermissions ?? new HashSet<string>(),
            UserPermissions = userPermissions ?? new List<string>(),
            UserService = userService,
            RoleService = roleService
        };
    }

    /// <summary>
    /// Creates a failed authorization result with a reason.
    /// </summary>
    public static AuthorizationResult Failure(string reason)
    {
        return new AuthorizationResult
        {
            IsSuccess = false,
            FailureReason = reason
        };
    }
}
