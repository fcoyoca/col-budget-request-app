using Asp.Versioning;
using FSH.Framework.Infrastructure.Auth.Policy;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.EquipmentFundingSource.Features.Delete.v1;
public static class DeleteEquipmentFundingSourceEndpoint
{
    internal static RouteHandlerBuilder MapEquipmentFundingSourceItemDeletionEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints
            .MapDelete("/{id:guid}", async (Guid id, ISender mediator) =>
            {
                await mediator.Send(new DeleteEquipmentFundingSourceCommand(id));
                return Results.NoContent();
            })
            .WithName(nameof(DeleteEquipmentFundingSourceEndpoint))
            .WithSummary("Deletes a EquipmentFundingSource item")
            .WithDescription("Deleted a EquipmentFundingSource item")
            .Produces(StatusCodes.Status204NoContent)
            .RequirePermission("Permissions.LookupCategories.Delete")
            .MapToApiVersion(new ApiVersion(1, 0));

    }
}
