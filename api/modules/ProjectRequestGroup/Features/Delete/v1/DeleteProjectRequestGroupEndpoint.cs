using Asp.Versioning;
using FSH.Framework.Infrastructure.Auth.Policy;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.ProjectRequestGroup.Features.Delete.v1;
public static class DeleteProjectRequestGroupEndpoint
{
    internal static RouteHandlerBuilder MapProjectRequestGroupItemDeletionEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints
            .MapDelete("/{id:guid}", async (Guid id, ISender mediator) =>
            {
                await mediator.Send(new DeleteProjectRequestGroupCommand(id));
                return Results.NoContent();
            })
            .WithName(nameof(DeleteProjectRequestGroupEndpoint))
            .WithSummary("Deletes a ProjectRequestGroup item")
            .WithDescription("Deleted a ProjectRequestGroup item")
            .Produces(StatusCodes.Status204NoContent)
            .RequirePermission("Permissions.LookupCategories.Delete")
            .MapToApiVersion(new ApiVersion(1, 0));

    }
}
