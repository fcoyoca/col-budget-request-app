using FSH.Framework.Core.Paging;
using FSH.Framework.Infrastructure.Auth.Policy;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.ProjectRequestStatus.Features.GetList.v1;

public static class GetProjectRequestStatusListEndpoint
{
    internal static RouteHandlerBuilder MapGetProjectRequestStatusListEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints.MapPost("/search", async (ISender mediator, [FromBody] PaginationFilter filter) =>
        {
            var response = await mediator.Send(new GetProjectRequestStatusListRequest(filter));
            return Results.Ok(response);
        })
        .WithName(nameof(GetProjectRequestStatusListEndpoint))
        .WithSummary("Gets a list of ProjectRequestStatus items with paging support")
        .WithDescription("Gets a list of ProjectRequestStatus items with paging support")
        .Produces<PagedList<ProjectRequestStatusDto>>()
        .RequirePermission("Permissions.LookupCategories.View")
        .MapToApiVersion(1);
    }
}
