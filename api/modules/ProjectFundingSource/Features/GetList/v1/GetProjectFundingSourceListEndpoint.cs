using FSH.Framework.Core.Paging;
using FSH.Framework.Infrastructure.Auth.Policy;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.ProjectFundingSource.Features.GetList.v1;

public static class GetProjectFundingSourceListEndpoint
{
    internal static RouteHandlerBuilder MapGetProjectFundingSourceListEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints.MapPost("/search", async (ISender mediator, [FromBody] PaginationFilter filter) =>
        {
            var response = await mediator.Send(new GetProjectFundingSourceListRequest(filter));
            return Results.Ok(response);
        })
        .WithName(nameof(GetProjectFundingSourceListEndpoint))
        .WithSummary("Gets a list of ProjectFundingSource items with paging support")
        .WithDescription("Gets a list of ProjectFundingSource items with paging support")
        .Produces<PagedList<ProjectFundingSourceDto>>()
        .RequirePermission("Permissions.LookupCategories.View")
        .MapToApiVersion(1);
    }
}
