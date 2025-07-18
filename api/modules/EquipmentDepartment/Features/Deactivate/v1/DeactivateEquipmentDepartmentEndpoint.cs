using Asp.Versioning;
using budget_request_app.WebApi.EquipmentDepartment.Features.Activate.v1;
using FSH.Framework.Infrastructure.Auth.Policy;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.EquipmentDepartment.Features.Deactivate.v1;
public static class DeactivateEquipmentDepartmentEndpoint
{
    internal static RouteHandlerBuilder MapEquipmentDepartmentItemDeactivationEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints.
            MapPatch("/{id:guid}/deactivate", async (Guid id, DeactivateEquipmentDepartmentCommand request, ISender mediator) =>
            {
                if (id != request.Id) return Results.BadRequest();
                var response = await mediator.Send(request);
                return Results.Ok(response);
            })
            .WithName(nameof(DeactivateEquipmentDepartmentEndpoint))
            .WithSummary("Activates a EquipmentDepartment item")
            .WithDescription("Activated a EquipmentDepartment item")
            .Produces<DeactivateEquipmentDepartmentResponse>(StatusCodes.Status200OK)
            .RequirePermission("Permissions.LookupCategories.Update")
            .MapToApiVersion(new ApiVersion(1, 0));

    }
}
