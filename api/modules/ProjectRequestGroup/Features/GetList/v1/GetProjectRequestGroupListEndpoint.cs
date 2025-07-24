using FSH.Framework.Core.Paging;
using FSH.Framework.Infrastructure.Auth.Policy;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.ProjectRequestGroup.Features.GetList.v1;

public static class GetProjectRequestGroupListEndpoint
{
    internal static RouteHandlerBuilder MapGetProjectRequestGroupListEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints.MapPost("/search", async (ISender mediator, [FromBody] PaginationFilter filter) =>
        {
            var response = await mediator.Send(new GetProjectRequestGroupListRequest(filter));
            return Results.Ok(response);
        })
        .WithName(nameof(GetProjectRequestGroupListEndpoint))
        .WithSummary("Gets a list of ProjectRequestGroup items with paging support")
        .WithDescription("Gets a list of ProjectRequestGroup items with paging support")
        .Produces<PagedList<ProjectRequestGroupDto>>()
        .RequirePermission("Permissions.LookupCategories.View")
        .MapToApiVersion(1);
    }
}
