using FSH.Framework.Core.Identity.Users.Abstractions;
using FSH.Framework.Infrastructure.Auth.Policy;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace FSH.Framework.Infrastructure.Identity.Users.Endpoints;
public static class GetUserByObjectIdEndpoint
{
    internal static RouteHandlerBuilder MapGetUserByObjectIdEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints.MapGet("/objectid", (string objectId, IUserService service) =>
        {
            return service.GetByObjectIdAsync(objectId, CancellationToken.None);
        })
        .WithName(nameof(GetUserByObjectIdEndpoint))
        .WithSummary("Get user profile by object ID using MS login")
        .RequirePermission("Permissions.Users.View")
        .WithDescription("Get another user's profile details by object ID using MS login.");
    }
}
