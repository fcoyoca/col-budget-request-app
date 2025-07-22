using Asp.Versioning;
using FSH.Framework.Infrastructure.Auth.Policy;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.ProjectBudgetIntroSectionOutlineItem.Features.Delete.v1;
public static class DeleteProjectBudgetIntroSectionOutlineItemEndpoint
{
    internal static RouteHandlerBuilder MapProjectBudgetIntroSectionOutlineItemItemDeletionEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints
            .MapDelete("/{id:guid}", async (Guid id, ISender mediator) =>
            {
                await mediator.Send(new DeleteProjectBudgetIntroSectionOutlineItemCommand(id));
                return Results.NoContent();
            })
            .WithName(nameof(DeleteProjectBudgetIntroSectionOutlineItemEndpoint))
            .WithSummary("Deletes a ProjectBudgetIntroSectionOutlineItem item")
            .WithDescription("Deleted a ProjectBudgetIntroSectionOutlineItem item")
            .Produces(StatusCodes.Status204NoContent)
            .RequirePermission("Permissions.LookupCategories.Delete")
            .MapToApiVersion(new ApiVersion(1, 0));

    }
}
