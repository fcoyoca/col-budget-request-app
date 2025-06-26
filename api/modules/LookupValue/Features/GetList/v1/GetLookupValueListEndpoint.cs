using FSH.Framework.Core.Paging;
using FSH.Framework.Infrastructure.Auth.Policy;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.LookupValue.Features.GetList.v1;

public static class GetLookupValueListEndpoint
{
    internal static RouteHandlerBuilder MapGetLookupValueListEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints.MapPost("/search", async (ISender mediator, [FromBody] PaginationFilter filter) =>
        {
            var response = await mediator.Send(new GetLookupValueListRequest(filter));
            return Results.Ok(response);
        })
        .WithName(nameof(GetLookupValueListEndpoint))
        .WithSummary("Gets a list of LookupValue items with paging support")
        .WithDescription("Gets a list of LookupValue items with paging support")
        .Produces<PagedList<LookupValueDto>>()
        //.RequirePermission("Permissions.LookupCategories.View")
        .MapToApiVersion(1);
    }
}
