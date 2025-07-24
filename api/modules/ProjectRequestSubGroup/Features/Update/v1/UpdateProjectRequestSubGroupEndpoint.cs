using Asp.Versioning;
using FSH.Framework.Infrastructure.Auth.Policy;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.ProjectRequestSubGroup.Features.Update.v1;
public static class UpdateProjectRequestSubGroupEndpoint
{
    internal static RouteHandlerBuilder MapProjectRequestSubGroupItemUpdationEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints.
            MapPut("/{id:guid}", async (Guid id, UpdateProjectRequestSubGroupCommand request, ISender mediator) =>
            {
                if (id != request.Id) return Results.BadRequest();
                var response = await mediator.Send(request);
                return Results.Ok(response);
            })
            .WithName(nameof(UpdateProjectRequestSubGroupEndpoint))
            .WithSummary("Updates a ProjectRequestSubGroup item")
            .WithDescription("Updated a ProjectRequestSubGroup item")
            .Produces<UpdateProjectRequestSubGroupResponse>(StatusCodes.Status200OK)
            .RequirePermission("Permissions.LookupCategories.Update")
            .MapToApiVersion(new ApiVersion(1, 0));

    }
}
