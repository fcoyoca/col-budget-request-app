using FSH.Framework.Core.Paging;
using FSH.Framework.Infrastructure.Auth.Policy;
using budget_request_app.WebApi.CapitalProject.Infrastructure.SubModules.CapitalProjects.Get.v1;
using budget_request_app.WebApi.CapitalProject.Infrastructure.SubModules.CapitalProjects.Search.v1;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.CapitalProject.Infrastructure.Endpoints.v1.CapitalProjects;
public static class SearchCapitalProjectsEndpoint
{
    internal static RouteHandlerBuilder MapGetCapitalProjectListEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints
            .MapPost("/search", async (ISender mediator, [FromBody] SearchCapitalProjectsCommand command) =>
            {
                var response = await mediator.Send(command);
                return Results.Ok(response);
            })
            .WithName(nameof(SearchCapitalProjectsEndpoint))
            .WithSummary("Gets a list of CapitalProjects")
            .WithDescription("Gets a list of CapitalProjects with pagination and filtering support")
            .Produces<PagedList<SearchCapitalProjectResponse>>()
            .AllowAnonymous()
            //.RequirePermission("Permissions.CapitalProjects.View")
            .MapToApiVersion(1);
    }
}

