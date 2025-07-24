using FSH.Framework.Core.Paging;
using FSH.Framework.Infrastructure.Auth.Policy;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.ProjectBudgetIntroSectionOutlineItem.Features.GetList.v1;

public static class GetProjectBudgetIntroSectionOutlineItemListEndpoint
{
    internal static RouteHandlerBuilder MapGetProjectBudgetIntroSectionOutlineItemListEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints.MapPost("/search", async (ISender mediator, [FromBody] PaginationFilter filter) =>
        {
            var response = await mediator.Send(new GetProjectBudgetIntroSectionOutlineItemListRequest(filter));
            return Results.Ok(response);
        })
        .WithName(nameof(GetProjectBudgetIntroSectionOutlineItemListEndpoint))
        .WithSummary("Gets a list of ProjectBudgetIntroSectionOutlineItem items with paging support")
        .WithDescription("Gets a list of ProjectBudgetIntroSectionOutlineItem items with paging support")
        .Produces<PagedList<ProjectBudgetIntroSectionOutlineItemDto>>()
        .RequirePermission("Permissions.LookupCategories.View")
        .MapToApiVersion(1);
    }
}
