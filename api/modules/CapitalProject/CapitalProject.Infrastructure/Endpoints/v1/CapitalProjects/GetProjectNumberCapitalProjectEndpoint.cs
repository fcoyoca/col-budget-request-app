using budget_request_app.WebApi.CapitalProject.Infrastructure.SubModules.CapitalProjects.GetProjectNumber.v1;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.CapitalProject.Infrastructure.Endpoints.v1.CapitalProjects;
public static class GetProjectNumberCapitalProjectEndpoint
{
    internal static RouteHandlerBuilder MapGetProjectNumberCapitalProjectEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints
            .MapGet("/projectNumber", async (ISender mediator) =>
            {
                var response = await mediator.Send(new GetProjectNumberCapitalProjectRequest());
                return Results.Ok(response);
            })
            .WithName(nameof(GetProjectNumberCapitalProjectEndpoint))
            .WithSummary("get project number capital project")
            .WithDescription("get project number capital project")
            .Produces<GetProjectNumberCapitalProjectResponse>()
            .AllowAnonymous()
            .MapToApiVersion(1);
    }
}
