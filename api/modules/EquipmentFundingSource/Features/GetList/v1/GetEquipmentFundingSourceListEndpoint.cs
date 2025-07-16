using FSH.Framework.Core.Paging;
using FSH.Framework.Infrastructure.Auth.Policy;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.EquipmentFundingSource.Features.GetList.v1;

public static class GetEquipmentFundingSourceListEndpoint
{
    internal static RouteHandlerBuilder MapGetEquipmentFundingSourceListEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints.MapPost("/search", async (ISender mediator, [FromBody] PaginationFilter filter) =>
        {
            var response = await mediator.Send(new GetEquipmentFundingSourceListRequest(filter));
            return Results.Ok(response);
        })
        .WithName(nameof(GetEquipmentFundingSourceListEndpoint))
        .WithSummary("Gets a list of EquipmentFundingSource items with paging support")
        .WithDescription("Gets a list of EquipmentFundingSource items with paging support")
        .Produces<PagedList<EquipmentFundingSourceDto>>()
        .RequirePermission("Permissions.LookupCategories.View")
        .MapToApiVersion(1);
    }
}
