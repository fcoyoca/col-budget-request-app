using Asp.Versioning;
using FSH.Framework.Infrastructure.Auth.Policy;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.LookupValue.Features.EquipmentDepartments.Activate.v1;
public static class ActivateEquipmentDepartmentEndpoint
{
    internal static RouteHandlerBuilder MapEquipmentDepartmentItemActivationEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints.
            MapPatch("/{id:guid}/activate", async (Guid id, ActivateEquipmentDepartmentCommand request, ISender mediator) =>
            {
                if (id != request.Id) return Results.BadRequest();
                var response = await mediator.Send(request);
                return Results.Ok(response);
            })
            .WithName(nameof(ActivateEquipmentDepartmentEndpoint))
            .WithSummary("Activates a EquipmentDepartment item")
            .WithDescription("Activated a EquipmentDepartment item")
            .Produces<ActivateEquipmentDepartmentResponse>(StatusCodes.Status200OK)
            .RequirePermission("Permissions.LookupCategories.Update")
            .MapToApiVersion(new ApiVersion(1, 0));

    }
}
