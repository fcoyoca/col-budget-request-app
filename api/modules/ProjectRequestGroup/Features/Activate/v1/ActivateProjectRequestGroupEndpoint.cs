using Asp.Versioning;
using FSH.Framework.Infrastructure.Auth.Policy;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.ProjectRequestGroup.Features.Activate.v1;
public static class ActivateProjectRequestGroupEndpoint
{
    internal static RouteHandlerBuilder MapProjectRequestGroupItemActivationEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints.
            MapPatch("/{id:guid}/activate", async (Guid id, ActivateProjectRequestGroupCommand request, ISender mediator) =>
            {
                if (id != request.Id) return Results.BadRequest();
                var response = await mediator.Send(request);
                return Results.Ok(response);
            })
            .WithName(nameof(ActivateProjectRequestGroupEndpoint))
            .WithSummary("Activates a ProjectRequestGroup item")
            .WithDescription("Activated a ProjectRequestGroup item")
            .Produces<ActivateProjectRequestGroupResponse>(StatusCodes.Status200OK)
            .RequirePermission("Permissions.LookupCategories.Update")
            .MapToApiVersion(new ApiVersion(1, 0));

    }
}
