using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace FSH.Framework.Infrastructure.Auth.Policy;
public static class RequiredPermissionDefaults
{
    public const string PolicyName = "RequiredPermission";
}

public static class RequiredPermissionAuthorizationExtensions
{
    public static AuthorizationPolicyBuilder RequireRequiredPermissions(this AuthorizationPolicyBuilder builder)
    {
        return builder
            .AddRequirements(new PermissionAuthorizationRequirement());
        // Add Azure AD specific requirements if needed
        // .RequireClaim("iss") // Ensures token has an issuer claim
        // .RequireClaim("oid"); // Ensures token has an object ID claim (Azure AD user ID)
    }

    public static AuthorizationBuilder AddRequiredPermissionPolicy(this AuthorizationBuilder builder)
    {
        // Define the default policy
        var defaultPolicy = new AuthorizationPolicyBuilder()
            .RequireAuthenticatedUser()
            .AddAuthenticationSchemes(JwtBearerDefaults.AuthenticationScheme)
            .RequireRequiredPermissions()
            .Build();

        // Add the named policy
        builder.AddPolicy(RequiredPermissionDefaults.PolicyName, defaultPolicy);

        // Set as default policy (optional but recommended)
        builder.SetDefaultPolicy(defaultPolicy);

        // Set as fallback policy to require auth by default
        builder.SetFallbackPolicy(defaultPolicy);

        // Register the handler
        builder.Services.TryAddEnumerable(
            ServiceDescriptor.Scoped<IAuthorizationHandler, RequiredPermissionAuthorizationHandler>());

        return builder;
    }
}
