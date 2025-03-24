using budget_request_app.WebApi.CapitalEquipment.Infrastructure.SubModules.CapitalEquipments.Delete.v1;
using FSH.Framework.Infrastructure.Auth.Policy;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.CapitalEquipment.Infrastructure.Endpoints.v1.CapitalEquipments;
public static class DeleteCapitalEquipmentEndpoint
{
    internal static RouteHandlerBuilder MapCapitalEquipmentDeleteEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints
            .MapDelete("/{id:guid}", async (Guid id, ISender mediator) =>
             {
                 await mediator.Send(new DeleteCapitalEquipmentCommand(id));
                 return Results.NoContent();
             })
            .WithName(nameof(DeleteCapitalEquipmentEndpoint))
            .WithSummary("deletes capitalEquipment by id")
            .WithDescription("deletes capitalEquipment by id")
            .Produces(StatusCodes.Status204NoContent)
            .RequirePermission("Permissions.CapitalEquipments.Delete")
            .MapToApiVersion(1);
    }
}
