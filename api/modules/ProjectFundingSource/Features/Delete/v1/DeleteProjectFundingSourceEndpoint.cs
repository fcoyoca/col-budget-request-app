using Asp.Versioning;
using FSH.Framework.Infrastructure.Auth.Policy;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.ProjectFundingSource.Features.Delete.v1;
public static class DeleteProjectFundingSourceEndpoint
{
    internal static RouteHandlerBuilder MapProjectFundingSourceItemDeletionEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints
            .MapDelete("/{id:guid}", async (Guid id, ISender mediator) =>
            {
                await mediator.Send(new DeleteProjectFundingSourceCommand(id));
                return Results.NoContent();
            })
            .WithName(nameof(DeleteProjectFundingSourceEndpoint))
            .WithSummary("Deletes a ProjectFundingSource item")
            .WithDescription("Deleted a ProjectFundingSource item")
            .Produces(StatusCodes.Status204NoContent)
            .RequirePermission("Permissions.LookupCategories.Delete")
            .MapToApiVersion(new ApiVersion(1, 0));

    }
}
