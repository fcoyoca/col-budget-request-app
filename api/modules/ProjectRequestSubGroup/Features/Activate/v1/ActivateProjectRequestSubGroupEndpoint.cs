using Asp.Versioning;
using FSH.Framework.Infrastructure.Auth.Policy;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.ProjectRequestSubGroup.Features.Activate.v1;
public static class ActivateProjectRequestSubGroupEndpoint
{
    internal static RouteHandlerBuilder MapProjectRequestSubGroupItemActivationEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints.
            MapPatch("/{id:guid}/activate", async (Guid id, ActivateProjectRequestSubGroupCommand request, ISender mediator) =>
            {
                if (id != request.Id) return Results.BadRequest();
                var response = await mediator.Send(request);
                return Results.Ok(response);
            })
            .WithName(nameof(ActivateProjectRequestSubGroupEndpoint))
            .WithSummary("Activates a ProjectRequestSubGroup item")
            .WithDescription("Activated a ProjectRequestSubGroup item")
            .Produces<ActivateProjectRequestSubGroupResponse>(StatusCodes.Status200OK)
            .RequirePermission("Permissions.LookupCategories.Update")
            .MapToApiVersion(new ApiVersion(1, 0));

    }
}
