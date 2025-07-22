using Asp.Versioning;
using budget_request_app.WebApi.ProjectBudgetIntroSectionOutlineItem.Features.Deactivate.v1;
using budget_request_app.WebApi.ProjectBudgetIntroSectionOutlineItem.Features.Activate.v1;
using budget_request_app.WebApi.ProjectBudgetIntroSectionOutlineItem.Features.Deactivate.v1;
using FSH.Framework.Infrastructure.Auth.Policy;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.ProjectBudgetIntroSectionOutlineItem.Features.Deactivate.v1;
public static class DeactivateProjectBudgetIntroSectionOutlineItemEndpoint
{
    internal static RouteHandlerBuilder MapProjectBudgetIntroSectionOutlineItemItemDeactivationEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints.
            MapPatch("/{id:guid}/deactivate", async (Guid id, DeactivateProjectBudgetIntroSectionOutlineItemCommand request, ISender mediator) =>
            {
                if (id != request.Id) return Results.BadRequest();
                var response = await mediator.Send(request);
                return Results.Ok(response);
            })
            .WithName(nameof(DeactivateProjectBudgetIntroSectionOutlineItemEndpoint))
            .WithSummary("Activates a ProjectBudgetIntroSectionOutlineItem item")
            .WithDescription("Activated a ProjectBudgetIntroSectionOutlineItem item")
            .Produces<DeactivateProjectBudgetIntroSectionOutlineItemResponse>(StatusCodes.Status200OK)
            .RequirePermission("Permissions.LookupCategories.Update")
            .MapToApiVersion(new ApiVersion(1, 0));

    }
}
