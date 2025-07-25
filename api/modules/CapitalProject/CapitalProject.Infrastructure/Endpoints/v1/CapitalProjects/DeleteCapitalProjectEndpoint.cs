using budget_request_app.Shared.Authorization;
using budget_request_app.WebApi.CapitalProject.Infrastructure.SubModules.CapitalProjects.Delete.v1;
using FSH.Framework.Infrastructure.Auth.Policy;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.CapitalProject.Infrastructure.Endpoints.v1.CapitalProjects;
public static class DeleteCapitalProjectEndpoint
{
    internal static RouteHandlerBuilder MapCapitalProjectDeleteEndpoint(this IEndpointRouteBuilder endpoints)
    {
        string requirePermission = FshPermission.NameFor(FshActions.Delete, FshResources.CapitalProjects);
        return endpoints
            .MapDelete("/{id:guid}", async (Guid id, ISender mediator) =>
             {
                 await mediator.Send(new DeleteCapitalProjectCommand(id));
                 return Results.NoContent();
             })
            .WithName(nameof(DeleteCapitalProjectEndpoint))
            .WithSummary("deletes capitalEquipment by id")
            .WithDescription("deletes capitalEquipment by id")
            .Produces(StatusCodes.Status204NoContent)
            .RequirePermission(requirePermission)
            .MapToApiVersion(1);
    }
}
