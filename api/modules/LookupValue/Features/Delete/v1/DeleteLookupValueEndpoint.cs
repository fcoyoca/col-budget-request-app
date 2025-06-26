using Asp.Versioning;
using FSH.Framework.Infrastructure.Auth.Policy;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.LookupValue.Features.Delete.v1;
public static class DeleteLookupValueEndpoint
{
    internal static RouteHandlerBuilder MapLookupValueItemDeletionEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints
            .MapDelete("/{id:guid}", async (Guid id, ISender mediator) =>
            {
                await mediator.Send(new DeleteLookupValueCommand(id));
                return Results.NoContent();
            })
            .WithName(nameof(DeleteLookupValueEndpoint))
            .WithSummary("Deletes a LookupValue item")
            .WithDescription("Deleted a LookupValue item")
            .Produces(StatusCodes.Status204NoContent)
            //.RequirePermission("Permissions.LookupCategories.Delete")
            .MapToApiVersion(new ApiVersion(1, 0));

    }
}
