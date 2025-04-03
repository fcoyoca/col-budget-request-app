using FSH.Framework.Infrastructure.Auth.Policy;
using budget_request_app.WebApi.CapitalEquipment.Infrastructure.SubModules.CapitalEquipments.Get.v1;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.CapitalEquipment.Infrastructure.Endpoints.v1.CapitalEquipments;
public static class GetCapitalEquipmentEndpoint
{
    internal static RouteHandlerBuilder MapGetCapitalEquipmentEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints
            .MapGet("/{id:guid}", async (Guid id, ISender mediator) =>
            {
                var response = await mediator.Send(new GetCapitalEquipmentRequest(id));
                return Results.Ok(response);
            })
            .WithName(nameof(GetCapitalEquipmentEndpoint))
            .WithSummary("gets CapitalEquipment by id")
            .WithDescription("gets CapitalEquipment by id")
            .Produces<GetCapitalEquipmentResponse>()
            .AllowAnonymous()
            //.RequirePermission("Permissions.CapitalEquipments.View")
            .MapToApiVersion(1);
    }
}
