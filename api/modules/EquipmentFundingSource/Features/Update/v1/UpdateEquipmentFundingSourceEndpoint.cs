using Asp.Versioning;
using FSH.Framework.Infrastructure.Auth.Policy;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.EquipmentFundingSource.Features.Update.v1;
public static class UpdateEquipmentFundingSourceEndpoint
{
    internal static RouteHandlerBuilder MapEquipmentFundingSourceItemUpdationEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints.
            MapPut("/{id:guid}", async (Guid id, UpdateEquipmentFundingSourceCommand request, ISender mediator) =>
            {
                if (id != request.Id) return Results.BadRequest();
                var response = await mediator.Send(request);
                return Results.Ok(response);
            })
            .WithName(nameof(UpdateEquipmentFundingSourceEndpoint))
            .WithSummary("Updates a EquipmentFundingSource item")
            .WithDescription("Updated a EquipmentFundingSource item")
            .Produces<UpdateEquipmentFundingSourceResponse>(StatusCodes.Status200OK)
            .RequirePermission("Permissions.LookupCategories.Update")
            .MapToApiVersion(new ApiVersion(1, 0));

    }
}
