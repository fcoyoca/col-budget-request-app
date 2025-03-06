using budget_request_app.WebApi.CapitalEquipment.Infrastructure.SubModules.CapitalEquipments.Update.v1;
using FSH.Framework.Infrastructure.Auth.Policy;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.CapitalEquipment.Infrastructure.Endpoints.v1.CapitalEquipments;
public static class UpdateCapitalEquipmentEndpoint
{
    internal static RouteHandlerBuilder MapCapitalEquipmentUpdateEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints
            .MapPut("/{id:guid}", async (Guid id, UpdateCapitalEquipmentCommand request, ISender mediator) =>
            {
                if (id != request.Id) return Results.BadRequest();
                var response = await mediator.Send(request);
                return Results.Ok(response);
            })
            .WithName(nameof(UpdateCapitalEquipmentEndpoint))
            .WithSummary("update a product")
            .WithDescription("update a product")
            .Produces<UpdateCapitalEquipmentResponse>()
            .RequirePermission("Permissions.CapitalEquipments.Update")
            .MapToApiVersion(1);
    }
}
