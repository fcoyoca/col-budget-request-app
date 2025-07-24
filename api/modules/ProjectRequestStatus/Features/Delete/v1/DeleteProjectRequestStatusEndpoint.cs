using Asp.Versioning;
using FSH.Framework.Infrastructure.Auth.Policy;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.ProjectRequestStatus.Features.Delete.v1;
public static class DeleteProjectRequestStatusEndpoint
{
    internal static RouteHandlerBuilder MapProjectRequestStatusItemDeletionEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints
            .MapDelete("/{id:guid}", async (Guid id, ISender mediator) =>
            {
                await mediator.Send(new DeleteProjectRequestStatusCommand(id));
                return Results.NoContent();
            })
            .WithName(nameof(DeleteProjectRequestStatusEndpoint))
            .WithSummary("Deletes a ProjectRequestStatus item")
            .WithDescription("Deleted a ProjectRequestStatus item")
            .Produces(StatusCodes.Status204NoContent)
            .RequirePermission("Permissions.LookupCategories.Delete")
            .MapToApiVersion(new ApiVersion(1, 0));

    }
}
