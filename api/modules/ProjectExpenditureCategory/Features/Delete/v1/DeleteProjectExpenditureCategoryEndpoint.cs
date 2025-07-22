using Asp.Versioning;
using FSH.Framework.Infrastructure.Auth.Policy;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.ProjectExpenditureCategory.Features.Delete.v1;
public static class DeleteProjectExpenditureCategoryEndpoint
{
    internal static RouteHandlerBuilder MapProjectExpenditureCategoryItemDeletionEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints
            .MapDelete("/{id:guid}", async (Guid id, ISender mediator) =>
            {
                await mediator.Send(new DeleteProjectExpenditureCategoryCommand(id));
                return Results.NoContent();
            })
            .WithName(nameof(DeleteProjectExpenditureCategoryEndpoint))
            .WithSummary("Deletes a ProjectExpenditureCategory item")
            .WithDescription("Deleted a ProjectExpenditureCategory item")
            .Produces(StatusCodes.Status204NoContent)
            .RequirePermission("Permissions.LookupCategories.Delete")
            .MapToApiVersion(new ApiVersion(1, 0));

    }
}
