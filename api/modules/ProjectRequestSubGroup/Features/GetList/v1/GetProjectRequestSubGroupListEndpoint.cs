using FSH.Framework.Core.Paging;
using FSH.Framework.Infrastructure.Auth.Policy;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.ProjectRequestSubGroup.Features.GetList.v1;

public static class GetProjectRequestSubGroupListEndpoint
{
    internal static RouteHandlerBuilder MapGetProjectRequestSubGroupListEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints.MapPost("/search", async (ISender mediator, [FromBody] PaginationFilter filter) =>
        {
            var response = await mediator.Send(new GetProjectRequestSubGroupListRequest(filter));
            return Results.Ok(response);
        })
        .WithName(nameof(GetProjectRequestSubGroupListEndpoint))
        .WithSummary("Gets a list of ProjectRequestSubGroup items with paging support")
        .WithDescription("Gets a list of ProjectRequestSubGroup items with paging support")
        .Produces<PagedList<ProjectRequestSubGroupDto>>()
        .RequirePermission("Permissions.LookupCategories.View")
        .MapToApiVersion(1);
    }
}
