using Asp.Versioning;
using FSH.Framework.Infrastructure.Auth.Policy;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.EquipmentDepartment.Features.Create.v1;
public static class CreateEquipmentDepartmentEndpoint
{
    internal static RouteHandlerBuilder MapEquipmentDepartmentItemCreationEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints.MapPost("/", async (CreateEquipmentDepartmentCommand request, ISender mediator) =>
                {
                    var response = await mediator.Send(request);
                    return Results.CreatedAtRoute(nameof(CreateEquipmentDepartmentEndpoint), new { id = response.Id }, response);
                })
                .WithName(nameof(CreateEquipmentDepartmentEndpoint))
                .WithSummary("Creates a EquipmentDepartment item")
                .WithDescription("Creates a EquipmentDepartment item")
                .Produces<CreateEquipmentDepartmentResponse>(StatusCodes.Status201Created)
                .RequirePermission("Permissions.LookupCategories.Create")
                .MapToApiVersion(new ApiVersion(1, 0));

    }
}
