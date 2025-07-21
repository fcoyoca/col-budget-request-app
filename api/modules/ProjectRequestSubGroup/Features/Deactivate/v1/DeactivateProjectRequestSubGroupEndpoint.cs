using Asp.Versioning;
using budget_request_app.WebApi.ProjectRequestSubGroup.Features.Activate.v1;
using FSH.Framework.Infrastructure.Auth.Policy;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.ProjectRequestSubGroup.Features.Deactivate.v1;
public static class DeactivateProjectRequestSubGroupEndpoint
{
    internal static RouteHandlerBuilder MapProjectRequestSubGroupItemDeactivationEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints.
            MapPatch("/{id:guid}/deactivate", async (Guid id, DeactivateProjectRequestSubGroupCommand request, ISender mediator) =>
            {
                if (id != request.Id) return Results.BadRequest();
                var response = await mediator.Send(request);
                return Results.Ok(response);
            })
            .WithName(nameof(DeactivateProjectRequestSubGroupEndpoint))
            .WithSummary("Activates a ProjectRequestSubGroup item")
            .WithDescription("Activated a ProjectRequestSubGroup item")
            .Produces<DeactivateProjectRequestSubGroupResponse>(StatusCodes.Status200OK)
            .RequirePermission("Permissions.LookupCategories.Update")
            .MapToApiVersion(new ApiVersion(1, 0));

    }
}
