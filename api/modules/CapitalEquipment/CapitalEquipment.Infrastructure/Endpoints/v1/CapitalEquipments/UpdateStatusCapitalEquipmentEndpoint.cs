using budget_request_app.WebApi.CapitalEquipment.Infrastructure.SubModules.CapitalEquipments.Update.v1;
using budget_request_app.WebApi.CapitalEquipment.Infrastructure.SubModules.CapitalEquipments.UpdateStatus.v1;
using FSH.Framework.Infrastructure.Auth.Policy;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.CapitalEquipment.Infrastructure.Endpoints.v1.CapitalEquipments;
public static class UpdateStatusCapitalEquipmentEndpoint
{
    internal static RouteHandlerBuilder MapCapitalEquipmentUpdateStatusEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints
            .MapPut("/statuses", async (UpdateStatusCapitalEquipmentCommand request, ISender mediator) =>
            {
                var response = await mediator.Send(request);
                return Results.Ok(response);
            })
            .WithName(nameof(UpdateStatusCapitalEquipmentEndpoint))
            .WithSummary("update an equipment status")
            .WithDescription("update an equipment status")
            .Produces<UpdateCapitalEquipmentResponse>()
            .RequirePermission("Permissions.CapitalEquipments.Update")
            .MapToApiVersion(1);
    }
}
