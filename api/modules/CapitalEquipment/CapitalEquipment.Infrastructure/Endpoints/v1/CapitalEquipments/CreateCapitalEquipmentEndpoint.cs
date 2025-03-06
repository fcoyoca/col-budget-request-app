using FSH.Framework.Infrastructure.Auth.Policy;
using budget_request_app.WebApi.CapitalEquipment.Infrastructure.SubModules.CapitalEquipments.Create.v1;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.CapitalEquipment.Infrastructure.Endpoints.v1.CapitalEquipments;
public static class CreateCapitalEquipmentEndpoint
{
    internal static RouteHandlerBuilder MapCapitalEquipmentCreationEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints
            .MapPost("/", async (CreateCapitalEquipmentCommand request, ISender mediator) =>
            {
                var response = await mediator.Send(request);
                return Results.Ok(response);
            })
            .WithName(nameof(CreateCapitalEquipmentEndpoint))
            .WithSummary("creates a CapitalEquipment")
            .WithDescription("creates a CapitalEquipment")
            .Produces<CreateCapitalEquipmentResponse>()
            .RequirePermission("Permissions.CapitalEquipments.Create")
            .MapToApiVersion(1);
    }
}
