using Asp.Versioning;
using FSH.Framework.Infrastructure.Auth.Policy;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.LookupValue.Features.Deactivate.v1;
public static class DeactivateLookupValueEndpoint
{
    internal static RouteHandlerBuilder MapLookupValueItemDeactivationEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints.
            MapPatch("/{id:guid}/deactivate", async (Guid id, DeactivateLookupValueCommand request, ISender mediator) =>
            {
                if (id != request.Id) return Results.BadRequest();
                var response = await mediator.Send(request);
                return Results.Ok(response);
            })
            .WithName(nameof(DeactivateLookupValueEndpoint))
            .WithSummary("Activates a LookupValue item")
            .WithDescription("Activated a LookupValue item")
            .Produces<DeactivateLookupValueResponse>(StatusCodes.Status200OK)
            //.RequirePermission("Permissions.LookupCategories.Update")
            .MapToApiVersion(new ApiVersion(1, 0));

    }
}
