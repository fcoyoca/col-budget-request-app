using budget_request_app.Shared.Authorization;
using budget_request_app.WebApi.CapitalProject.Infrastructure.SubModules.CapitalProjects.Update.v1;
using budget_request_app.WebApi.CapitalProject.Infrastructure.SubModules.CapitalProjects.UpdateStatus.v1;
using FSH.Framework.Infrastructure.Auth.Policy;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.CapitalProject.Infrastructure.Endpoints.v1.CapitalProjects;
public static class UpdateStatusCapitalProjectEndpoint
{
    internal static RouteHandlerBuilder MapCapitalProjectUpdateStatusEndpoint(this IEndpointRouteBuilder endpoints)
    {
        string requirePermission = FshPermission.NameFor(FshActions.Update, FshResources.CapitalProjects);
        return endpoints
            .MapPut("/statuses", async (UpdateStatusCapitalProjectCommand request, ISender mediator) =>
            {
                var response = await mediator.Send(request);
                return Results.Ok(response);
            })
            .WithName(nameof(UpdateStatusCapitalProjectEndpoint))
            .WithSummary("update an project status")
            .WithDescription("update an project status")
            .Produces<UpdateCapitalProjectResponse>()
            .RequirePermission(requirePermission)
            .MapToApiVersion(1);
    }
}
