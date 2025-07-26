using Asp.Versioning;
using FSH.Framework.Infrastructure.Auth.Policy;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.LookupValue.Features.EquipmentDepartments.Delete.v1;
public static class DeleteEquipmentDepartmentEndpoint
{
    internal static RouteHandlerBuilder MapEquipmentDepartmentItemDeletionEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints
            .MapDelete("/{id:guid}", async (Guid id, ISender mediator) =>
            {
                await mediator.Send(new DeleteEquipmentDepartmentCommand(id));
                return Results.NoContent();
            })
            .WithName(nameof(DeleteEquipmentDepartmentEndpoint))
            .WithSummary("Deletes a EquipmentDepartment item")
            .WithDescription("Deleted a EquipmentDepartment item")
            .Produces(StatusCodes.Status204NoContent)
            .RequirePermission("Permissions.LookupCategories.Delete")
            .MapToApiVersion(new ApiVersion(1, 0));

    }
}
