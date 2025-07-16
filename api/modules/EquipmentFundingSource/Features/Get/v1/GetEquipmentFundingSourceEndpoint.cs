using FSH.Framework.Infrastructure.Auth.Policy;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.EquipmentFundingSource.Features.Get.v1;
public static class GetEquipmentFundingSourceEndpoint
{
    internal static RouteHandlerBuilder MapGetEquipmentFundingSourceEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints.MapGet("/{id:guid}", async (Guid id, ISender mediator) =>
                        {
                            var response = await mediator.Send(new GetEquipmentFundingSourceRequest(id));
                            return Results.Ok(response);
                        })
                        .WithName(nameof(GetEquipmentFundingSourceEndpoint))
                        .WithSummary("gets EquipmentFundingSource item by id")
                        .WithDescription("gets EquipmentFundingSource item by id")
                        .Produces<GetEquipmentFundingSourceResponse>()
                        .RequirePermission("Permissions.LookupCategories.View")
                        .MapToApiVersion(1);
    }
}
