using Asp.Versioning;
using FSH.Framework.Infrastructure.Auth.Policy;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.LookupValue.Features.EquipmentDepartments.Update.v1;
public static class UpdateEquipmentDepartmentEndpoint
{
    internal static RouteHandlerBuilder MapEquipmentDepartmentItemUpdationEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints.
            MapPut("/{id:guid}", async (Guid id, UpdateEquipmentDepartmentCommand request, ISender mediator) =>
            {
                if (id != request.Id) return Results.BadRequest();
                var response = await mediator.Send(request);
                return Results.Ok(response);
            })
            .WithName(nameof(UpdateEquipmentDepartmentEndpoint))
            .WithSummary("Updates a EquipmentDepartment item")
            .WithDescription("Updated a EquipmentDepartment item")
            .Produces<UpdateEquipmentDepartmentResponse>(StatusCodes.Status200OK)
            .RequirePermission("Permissions.LookupCategories.Update")
            .MapToApiVersion(new ApiVersion(1, 0));

    }
}
