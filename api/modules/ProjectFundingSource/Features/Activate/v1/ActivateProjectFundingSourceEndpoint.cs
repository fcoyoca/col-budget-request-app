using Asp.Versioning;
using FSH.Framework.Infrastructure.Auth.Policy;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.ProjectFundingSource.Features.Activate.v1;
public static class ActivateProjectFundingSourceEndpoint
{
    internal static RouteHandlerBuilder MapProjectFundingSourceItemActivationEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints.
            MapPatch("/{id:guid}/activate", async (Guid id, ActivateProjectFundingSourceCommand request, ISender mediator) =>
            {
                if (id != request.Id) return Results.BadRequest();
                var response = await mediator.Send(request);
                return Results.Ok(response);
            })
            .WithName(nameof(ActivateProjectFundingSourceEndpoint))
            .WithSummary("Activates a ProjectFundingSource item")
            .WithDescription("Activated a ProjectFundingSource item")
            .Produces<ActivateProjectFundingSourceResponse>(StatusCodes.Status200OK)
            .RequirePermission("Permissions.LookupCategories.Update")
            .MapToApiVersion(new ApiVersion(1, 0));

    }
}
