using budget_request_app.Shared.Authorization;
using budget_request_app.WebApi.CapitalProject.Infrastructure.SubModules.CapitalProjects.Create.v1;
using FSH.Framework.Infrastructure.Auth.Policy;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.CapitalProject.Infrastructure.Endpoints.v1.CapitalProjects;
public static class CreateCapitalProjectEndpoint
{
    internal static RouteHandlerBuilder MapCapitalProjectCreationEndpoint(this IEndpointRouteBuilder endpoints)
    {
        string requirePermission = FshPermission.NameFor(FshActions.Create, FshResources.CapitalProjects);
        return endpoints
            .MapPost("/", async (CreateCapitalProjectCommand request, ISender mediator) =>
            {
                var response = await mediator.Send(request);
                return Results.Ok(response);
            })
            .WithName(nameof(CreateCapitalProjectEndpoint))
            .WithSummary("creates a CapitalProject")
            .WithDescription("creates a CapitalProject")
            .Produces<CreateCapitalProjectResponse>()
            .RequirePermission(requirePermission)
            .MapToApiVersion(1);
    }
}
