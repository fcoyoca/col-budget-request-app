using Asp.Versioning;
using FSH.Framework.Infrastructure.Auth.Policy;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.LookupValue.Features.Activate.v1;
public static class ActivateLookupValueEndpoint
{
    internal static RouteHandlerBuilder MapLookupValueItemActivationEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints.
            MapPatch("/{id:guid}/activate", async (Guid id, ActivateLookupValueCommand request, ISender mediator) =>
            {
                if (id != request.Id) return Results.BadRequest();
                var response = await mediator.Send(request);
                return Results.Ok(response);
            })
            .WithName(nameof(ActivateLookupValueEndpoint))
            .WithSummary("Activates a LookupValue item")
            .WithDescription("Activated a LookupValue item")
            .Produces<ActivateLookupValueResponse>(StatusCodes.Status200OK)
            //.RequirePermission("Permissions.LookupCategories.Update")
            .AllowAnonymous()
            .MapToApiVersion(new ApiVersion(1, 0));

    }
}
