using FSH.Framework.Core.Paging;
using FSH.Framework.Infrastructure.Auth.Policy;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.LookupCategory.Features.GetList.v1;

public static class GetLookupCategoryListEndpoint
{
    internal static RouteHandlerBuilder MapGetLookupCategoryListEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints.MapPost("/search", async (ISender mediator, [FromBody] PaginationFilter filter) =>
        {
            var response = await mediator.Send(new GetLookupCategoryListRequest(filter));
            return Results.Ok(response);
        })
        .WithName(nameof(GetLookupCategoryListEndpoint))
        .WithSummary("Gets a list of LookupCategory items with paging support")
        .WithDescription("Gets a list of LookupCategory items with paging support")
        .Produces<PagedList<LookupCategoryDto>>()
        .RequirePermission("Permissions.LookupCategories.View")
        .MapToApiVersion(1);
    }
}
