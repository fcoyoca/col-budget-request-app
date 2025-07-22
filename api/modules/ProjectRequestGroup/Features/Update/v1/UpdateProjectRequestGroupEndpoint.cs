using Asp.Versioning;
using FSH.Framework.Infrastructure.Auth.Policy;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.ProjectRequestGroup.Features.Update.v1;
public static class UpdateProjectRequestGroupEndpoint
{
    internal static RouteHandlerBuilder MapProjectRequestGroupItemUpdationEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints.
            MapPut("/{id:guid}", async (Guid id, UpdateProjectRequestGroupCommand request, ISender mediator) =>
            {
                if (id != request.Id) return Results.BadRequest();
                var response = await mediator.Send(request);
                return Results.Ok(response);
            })
            .WithName(nameof(UpdateProjectRequestGroupEndpoint))
            .WithSummary("Updates a ProjectRequestGroup item")
            .WithDescription("Updated a ProjectRequestGroup item")
            .Produces<UpdateProjectRequestGroupResponse>(StatusCodes.Status200OK)
            .RequirePermission("Permissions.LookupCategories.Update")
            .MapToApiVersion(new ApiVersion(1, 0));

    }
}
