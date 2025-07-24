using Asp.Versioning;
using FSH.Framework.Infrastructure.Auth.Policy;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.ProjectBudgetIntroSectionOutlineItem.Features.Create.v1;
public static class CreateProjectBudgetIntroSectionOutlineItemEndpoint
{
    internal static RouteHandlerBuilder MapProjectBudgetIntroSectionOutlineItemItemCreationEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints.MapPost("/", async (CreateProjectBudgetIntroSectionOutlineItemCommand request, ISender mediator) =>
                {
                    var response = await mediator.Send(request);
                    return Results.CreatedAtRoute(nameof(CreateProjectBudgetIntroSectionOutlineItemEndpoint), new { id = response.Id }, response);
                })
                .WithName(nameof(CreateProjectBudgetIntroSectionOutlineItemEndpoint))
                .WithSummary("Creates a ProjectBudgetIntroSectionOutlineItem item")
                .WithDescription("Creates a ProjectBudgetIntroSectionOutlineItem item")
                .Produces<CreateProjectBudgetIntroSectionOutlineItemResponse>(StatusCodes.Status201Created)
                .RequirePermission("Permissions.LookupCategories.Create")
                .MapToApiVersion(new ApiVersion(1, 0));

    }
}
