using Asp.Versioning;
using budget_request_app.WebApi.ProjectExpenditureCategory.Features.Activate.v1;
using FSH.Framework.Infrastructure.Auth.Policy;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.ProjectExpenditureCategory.Features.Deactivate.v1;
public static class DeactivateProjectExpenditureCategoryEndpoint
{
    internal static RouteHandlerBuilder MapProjectExpenditureCategoryItemDeactivationEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints.
            MapPatch("/{id:guid}/deactivate", async (Guid id, DeactivateProjectExpenditureCategoryCommand request, ISender mediator) =>
            {
                if (id != request.Id) return Results.BadRequest();
                var response = await mediator.Send(request);
                return Results.Ok(response);
            })
            .WithName(nameof(DeactivateProjectExpenditureCategoryEndpoint))
            .WithSummary("Activates a ProjectExpenditureCategory item")
            .WithDescription("Activated a ProjectExpenditureCategory item")
            .Produces<DeactivateProjectExpenditureCategoryResponse>(StatusCodes.Status200OK)
            .RequirePermission("Permissions.LookupCategories.Update")
            .MapToApiVersion(new ApiVersion(1, 0));

    }
}
