using Asp.Versioning;
using budget_request_app.WebApi.ProjectRequestStatus.Features.Deactivate.v1;
using budget_request_app.WebApi.ProjectRequestStatus.Features.Activate.v1;
using budget_request_app.WebApi.ProjectRequestStatus.Features.Deactivate.v1;
using FSH.Framework.Infrastructure.Auth.Policy;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.ProjectRequestStatus.Features.Deactivate.v1;
public static class DeactivateProjectRequestStatusEndpoint
{
    internal static RouteHandlerBuilder MapProjectRequestStatusItemDeactivationEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints.
            MapPatch("/{id:guid}/deactivate", async (Guid id, DeactivateProjectRequestStatusCommand request, ISender mediator) =>
            {
                if (id != request.Id) return Results.BadRequest();
                var response = await mediator.Send(request);
                return Results.Ok(response);
            })
            .WithName(nameof(DeactivateProjectRequestStatusEndpoint))
            .WithSummary("Activates a ProjectRequestStatus item")
            .WithDescription("Activated a ProjectRequestStatus item")
            .Produces<DeactivateProjectRequestStatusResponse>(StatusCodes.Status200OK)
            .RequirePermission("Permissions.LookupCategories.Update")
            .MapToApiVersion(new ApiVersion(1, 0));

    }
}
