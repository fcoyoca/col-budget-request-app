using FSH.Framework.Infrastructure.Auth.Policy;
using budget_request_app.WebApi.CapitalProject.Infrastructure.SubModules.CapitalProjects.Create.v1;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.CapitalProject.Infrastructure.Endpoints.v1.CapitalProjects;
public static class CreateCapitalProjectEndpoint
{
    internal static RouteHandlerBuilder MapCapitalProjectCreationEndpoint(this IEndpointRouteBuilder endpoints)
    {
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
            .RequirePermission("Permissions.CapitalProjects.Create")
            .MapToApiVersion(1);
    }
}
