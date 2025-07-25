using budget_request_app.Shared.Authorization;
using budget_request_app.WebApi.CapitalProject.Infrastructure.SubModules.CapitalProjects.GetProjectNumber.v1;
using FSH.Framework.Infrastructure.Auth.Policy;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.CapitalProject.Infrastructure.Endpoints.v1.CapitalProjects;
public static class GetProjectNumberCapitalProjectEndpoint
{
    internal static RouteHandlerBuilder MapGetProjectNumberCapitalProjectEndpoint(this IEndpointRouteBuilder endpoints)
    {
        string requirePermission = FshPermission.NameFor(FshActions.View, FshResources.CapitalProjects);
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
            .RequirePermission(requirePermission)
            .MapToApiVersion(1);
    }
}
