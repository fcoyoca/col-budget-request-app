using budget_request_app.Shared.Authorization;
using budget_request_app.WebApi.CapitalEquipment.Infrastructure.SubModules.CapitalEquipments.Create.v1;
using FSH.Framework.Infrastructure.Auth.Policy;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.CapitalEquipment.Infrastructure.Endpoints.v1.CapitalEquipments;
public static class CreateCapitalEquipmentEndpoint
{
    internal static RouteHandlerBuilder MapCapitalEquipmentCreationEndpoint(this IEndpointRouteBuilder endpoints)
    {
        string requirePermission = FshPermission.NameFor(FshActions.Create, FshResources.CapitalEquipments);

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
            .RequirePermission(requirePermission)
            .MapToApiVersion(1);
    }
}
