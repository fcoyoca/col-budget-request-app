using FSH.Framework.Infrastructure.Auth.Policy;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.LookupValue.Features.EquipmentDepartments.Get.v1;
public static class GetEquipmentDepartmentEndpoint
{
    internal static RouteHandlerBuilder MapGetEquipmentDepartmentEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints.MapGet("/{id:guid}", async (Guid id, ISender mediator) =>
                        {
                            var response = await mediator.Send(new GetEquipmentDepartmentRequest(id));
                            return Results.Ok(response);
                        })
                        .WithName(nameof(GetEquipmentDepartmentEndpoint))
                        .WithSummary("gets EquipmentDepartment item by id")
                        .WithDescription("gets EquipmentDepartment item by id")
                        .Produces<GetEquipmentDepartmentResponse>()
                        .RequirePermission("Permissions.LookupCategories.View")
                        .MapToApiVersion(1);
    }
}
