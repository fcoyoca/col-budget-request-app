using Asp.Versioning;
using FSH.Framework.Infrastructure.Auth.Policy;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.ProjectRequestStatus.Features.Update.v1;
public static class UpdateProjectRequestStatusEndpoint
{
    internal static RouteHandlerBuilder MapProjectRequestStatusItemUpdationEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints.
            MapPut("/{id:guid}", async (Guid id, UpdateProjectRequestStatusCommand request, ISender mediator) =>
            {
                if (id != request.Id) return Results.BadRequest();
                var response = await mediator.Send(request);
                return Results.Ok(response);
            })
            .WithName(nameof(UpdateProjectRequestStatusEndpoint))
            .WithSummary("Updates a ProjectRequestStatus item")
            .WithDescription("Updated a ProjectRequestStatus item")
            .Produces<UpdateProjectRequestStatusResponse>(StatusCodes.Status200OK)
            .RequirePermission("Permissions.LookupCategories.Update")
            .MapToApiVersion(new ApiVersion(1, 0));

    }
}
