using FSH.Framework.Core.Paging;
using FSH.Framework.Infrastructure.Auth.Policy;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.ProjectExpenditureCategory.Features.GetList.v1;

public static class GetProjectExpenditureCategoryListEndpoint
{
    internal static RouteHandlerBuilder MapGetProjectExpenditureCategoryListEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints.MapPost("/search", async (ISender mediator, [FromBody] PaginationFilter filter) =>
        {
            var response = await mediator.Send(new GetProjectExpenditureCategoryListRequest(filter));
            return Results.Ok(response);
        })
        .WithName(nameof(GetProjectExpenditureCategoryListEndpoint))
        .WithSummary("Gets a list of ProjectExpenditureCategory items with paging support")
        .WithDescription("Gets a list of ProjectExpenditureCategory items with paging support")
        .Produces<PagedList<ProjectExpenditureCategoryDto>>()
        .RequirePermission("Permissions.LookupCategories.View")
        .MapToApiVersion(1);
    }
}
