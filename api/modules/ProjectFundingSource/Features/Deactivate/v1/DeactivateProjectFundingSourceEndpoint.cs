using Asp.Versioning;
using FSH.Framework.Infrastructure.Auth.Policy;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.ProjectFundingSource.Features.Deactivate.v1;
public static class DeactivateProjectFundingSourceEndpoint
{
    internal static RouteHandlerBuilder MapProjectFundingSourceItemDeactivationEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints.
            MapPatch("/{id:guid}/deactivate", async (Guid id, DeactivateProjectFundingSourceCommand request, ISender mediator) =>
            {
                if (id != request.Id) return Results.BadRequest();
                var response = await mediator.Send(request);
                return Results.Ok(response);
            })
            .WithName(nameof(DeactivateProjectFundingSourceEndpoint))
            .WithSummary("Activates a ProjectFundingSource item")
            .WithDescription("Activated a ProjectFundingSource item")
            .Produces<DeactivateProjectFundingSourceResponse>(StatusCodes.Status200OK)
            .RequirePermission("Permissions.LookupCategories.Update")
            .MapToApiVersion(new ApiVersion(1, 0));

    }
}
