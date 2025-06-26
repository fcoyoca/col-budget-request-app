using Asp.Versioning;
using FSH.Framework.Infrastructure.Auth.Policy;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.LookupCategory.Features.Delete.v1;
public static class DeleteLookupCategoryEndpoint
{
    internal static RouteHandlerBuilder MapLookupCategoryItemDeletionEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints
            .MapDelete("/{id:guid}", async (Guid id, ISender mediator) =>
            {
                await mediator.Send(new DeleteLookupCategoryCommand(id));
                return Results.NoContent();
            })
            .WithName(nameof(DeleteLookupCategoryEndpoint))
            .WithSummary("Deletes a LookupCategory item")
            .WithDescription("Deleted a LookupCategory item")
            .Produces(StatusCodes.Status204NoContent)
            //.RequirePermission("Permissions.LookupCategories.Delete")
            .MapToApiVersion(new ApiVersion(1, 0));

    }
}
