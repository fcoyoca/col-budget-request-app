using FSH.Framework.Core.Paging;
using FSH.Framework.Infrastructure.Auth.Policy;
using budget_request_app.WebApi.CapitalEquipment.Infrastructure.SubModules.CapitalEquipments.Get.v1;
using budget_request_app.WebApi.CapitalEquipment.Infrastructure.SubModules.CapitalEquipments.Search.v1;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.CapitalEquipment.Infrastructure.Endpoints.v1.CapitalEquipments;
public static class SearchCapitalEquipmentsEndpoint
{
    internal static RouteHandlerBuilder MapGetCapitalEquipmentListEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints
            .MapPost("/search", async (ISender mediator, [FromBody] SearchCapitalEquipmentsCommand command) =>
            {
                var response = await mediator.Send(command);
                return Results.Ok(response);
            })
            .WithName(nameof(SearchCapitalEquipmentsEndpoint))
            .WithSummary("Gets a list of CapitalEquipments")
            .WithDescription("Gets a list of CapitalEquipments with pagination and filtering support")
            .Produces<PagedList<GetCapitalEquipmentResponse>>()
            .RequirePermission("Permissions.CapitalEquipments.View")
            .MapToApiVersion(1);
    }
}

