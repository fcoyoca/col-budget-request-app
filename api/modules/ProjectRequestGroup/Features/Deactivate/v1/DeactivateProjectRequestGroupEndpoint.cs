using Asp.Versioning;
using budget_request_app.WebApi.ProjectRequestGroup.Features.Activate.v1;
using FSH.Framework.Infrastructure.Auth.Policy;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.ProjectRequestGroup.Features.Deactivate.v1;
public static class DeactivateProjectRequestGroupEndpoint
{
    internal static RouteHandlerBuilder MapProjectRequestGroupItemDeactivationEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints.
            MapPatch("/{id:guid}/deactivate", async (Guid id, DeactivateProjectRequestGroupCommand request, ISender mediator) =>
            {
                if (id != request.Id) return Results.BadRequest();
                var response = await mediator.Send(request);
                return Results.Ok(response);
            })
            .WithName(nameof(DeactivateProjectRequestGroupEndpoint))
            .WithSummary("Activates a ProjectRequestGroup item")
            .WithDescription("Activated a ProjectRequestGroup item")
            .Produces<DeactivateProjectRequestGroupResponse>(StatusCodes.Status200OK)
            .RequirePermission("Permissions.LookupCategories.Update")
            .MapToApiVersion(new ApiVersion(1, 0));

    }
}
