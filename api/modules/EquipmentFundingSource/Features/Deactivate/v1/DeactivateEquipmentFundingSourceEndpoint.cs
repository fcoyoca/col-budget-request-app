using Asp.Versioning;
using budget_request_app.WebApi.EquipmentFundingSource.Features.Activate.v1;
using FSH.Framework.Infrastructure.Auth.Policy;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.EquipmentFundingSource.Features.Deactivate.v1;
public static class DeactivateEquipmentFundingSourceEndpoint
{
    internal static RouteHandlerBuilder MapEquipmentFundingSourceItemDeactivationEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints.
            MapPatch("/{id:guid}/deactivate", async (Guid id, DeactivateEquipmentFundingSourceCommand request, ISender mediator) =>
            {
                if (id != request.Id) return Results.BadRequest();
                var response = await mediator.Send(request);
                return Results.Ok(response);
            })
            .WithName(nameof(DeactivateEquipmentFundingSourceEndpoint))
            .WithSummary("Activates a EquipmentFundingSource item")
            .WithDescription("Activated a EquipmentFundingSource item")
            .Produces<DeactivateEquipmentFundingSourceResponse>(StatusCodes.Status200OK)
            .RequirePermission("Permissions.LookupCategories.Update")
            .MapToApiVersion(new ApiVersion(1, 0));

    }
}
