using Asp.Versioning;
using FSH.Framework.Infrastructure.Auth.Policy;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.ProjectRequestStatus.Features.Activate.v1;
public static class ActivateProjectRequestStatusEndpoint
{
    internal static RouteHandlerBuilder MapProjectRequestStatusItemActivationEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints.
            MapPatch("/{id:guid}/activate", async (Guid id, ActivateProjectRequestStatusCommand request, ISender mediator) =>
            {
                if (id != request.Id) return Results.BadRequest();
                var response = await mediator.Send(request);
                return Results.Ok(response);
            })
            .WithName(nameof(ActivateProjectRequestStatusEndpoint))
            .WithSummary("Activates a ProjectRequestStatus item")
            .WithDescription("Activated a ProjectRequestStatus item")
            .Produces<ActivateProjectRequestStatusResponse>(StatusCodes.Status200OK)
            .RequirePermission("Permissions.LookupCategories.Update")
            .MapToApiVersion(new ApiVersion(1, 0));

    }
}
