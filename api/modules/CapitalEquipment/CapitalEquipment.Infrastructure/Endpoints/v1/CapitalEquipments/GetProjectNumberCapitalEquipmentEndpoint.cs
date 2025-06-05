using budget_request_app.WebApi.CapitalEquipment.Infrastructure.SubModules.CapitalEquipments.GetProjectNumber.v1;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.CapitalEquipment.Infrastructure.Endpoints.v1.CapitalEquipments;
public static class GetProjectNumberCapitalEquipmentEndpoint
{
    internal static RouteHandlerBuilder MapGetProjectNumberCapitalEquipmentEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints
            .MapGet("/projectNumber", async (ISender mediator) =>
            {
                var response = await mediator.Send(new GetProjectNumberCapitalEquipmentRequest());
                return Results.Ok(response);
            })
            .WithName(nameof(GetProjectNumberCapitalEquipmentEndpoint))
            .WithSummary("get projectNumber")
            .WithDescription("get projectNumber")
            .Produces<GetProjectNumberCapitalEquipmentResponse>()
            .AllowAnonymous()
            //.RequirePermission("Permissions.CapitalEquipments.View")
            .MapToApiVersion(1);
    }
}
