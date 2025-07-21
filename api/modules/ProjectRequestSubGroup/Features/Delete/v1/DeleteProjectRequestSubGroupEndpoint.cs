using Asp.Versioning;
using FSH.Framework.Infrastructure.Auth.Policy;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.ProjectRequestSubGroup.Features.Delete.v1;
public static class DeleteProjectRequestSubGroupEndpoint
{
    internal static RouteHandlerBuilder MapProjectRequestSubGroupItemDeletionEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints
            .MapDelete("/{id:guid}", async (Guid id, ISender mediator) =>
            {
                await mediator.Send(new DeleteProjectRequestSubGroupCommand(id));
                return Results.NoContent();
            })
            .WithName(nameof(DeleteProjectRequestSubGroupEndpoint))
            .WithSummary("Deletes a ProjectRequestSubGroup item")
            .WithDescription("Deleted a ProjectRequestSubGroup item")
            .Produces(StatusCodes.Status204NoContent)
            .RequirePermission("Permissions.LookupCategories.Delete")
            .MapToApiVersion(new ApiVersion(1, 0));

    }
}
