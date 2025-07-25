using budget_request_app.Shared.Authorization;
using budget_request_app.WebApi.CapitalProject.Infrastructure.SubModules.CapitalProjects.Get.v1;
using FSH.Framework.Infrastructure.Auth.Policy;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.CapitalProject.Infrastructure.Endpoints.v1.CapitalProjects;
public static class GetCapitalProjectEndpoint
{
    internal static RouteHandlerBuilder MapGetCapitalProjectEndpoint(this IEndpointRouteBuilder endpoints)
    {
        string requirePermission = FshPermission.NameFor(FshActions.View, FshResources.CapitalProjects);
        return endpoints
            .MapGet("/{id:guid}", async (Guid id, ISender mediator) =>
            {
                var response = await mediator.Send(new GetCapitalProjectRequest(id));
                return Results.Ok(response);
            })
            .WithName(nameof(GetCapitalProjectEndpoint))
            .WithSummary("gets CapitalProject by id")
            .WithDescription("gets CapitalProject by id")
            .Produces<GetCapitalProjectResponse>()
            .AllowAnonymous()
            .RequirePermission(requirePermission)
            .MapToApiVersion(1);
    }
}
