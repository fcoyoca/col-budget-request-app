using FSH.Framework.Infrastructure.Auth.Policy;
using budget_request_app.WebApi.CapitalProject.Infrastructure.SubModules.CapitalProjects.Update.v1;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.CapitalProject.Infrastructure.Endpoints.v1.CapitalProjects;
public static class UpdateCapitalProjectEndpoint
{
    internal static RouteHandlerBuilder MapCapitalProjectUpdateEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints
            .MapPost("/", async (UpdateCapitalProjectCommand request, ISender mediator) =>
            {
                var response = await mediator.Send(request);
                return Results.Ok(response);
            })
            .WithName(nameof(UpdateCapitalProjectEndpoint))
            .WithSummary("updates a CapitalProject")
            .WithDescription("updates a CapitalProject")
            .Produces<UpdateCapitalProjectResponse>()
            .RequirePermission("Permissions.CapitalProjects.Update")
            .MapToApiVersion(1);
    }
}
