using budget_request_app.WebApi.ProjectBudgetIntroSectionOutlineItem.Features.Get.v1;
using budget_request_app.WebApi.ProjectBudgetIntroSectionOutlineItem.Features.Get.v1;
using FSH.Framework.Infrastructure.Auth.Policy;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.ProjectBudgetIntroSectionOutlineItem.Features.Get.v1;
public static class GetProjectBudgetIntroSectionOutlineItemEndpoint
{
    internal static RouteHandlerBuilder MapGetProjectBudgetIntroSectionOutlineItemEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints.MapGet("/{id:guid}", async (Guid id, ISender mediator) =>
                        {
                            var response = await mediator.Send(new GetProjectBudgetIntroSectionOutlineItemRequest(id));
                            return Results.Ok(response);
                        })
                        .WithName(nameof(GetProjectBudgetIntroSectionOutlineItemEndpoint))
                        .WithSummary("gets ProjectBudgetIntroSectionOutlineItem item by id")
                        .WithDescription("gets ProjectBudgetIntroSectionOutlineItem item by id")
                        .Produces<GetProjectBudgetIntroSectionOutlineItemResponse>()
                        .RequirePermission("Permissions.LookupCategories.View")
                        .MapToApiVersion(1);
    }
}
