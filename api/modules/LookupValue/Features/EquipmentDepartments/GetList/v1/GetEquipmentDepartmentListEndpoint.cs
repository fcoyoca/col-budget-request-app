using FSH.Framework.Core.Paging;
using FSH.Framework.Infrastructure.Auth.Policy;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.LookupValue.Features.EquipmentDepartments.GetList.v1;

public static class GetEquipmentDepartmentListEndpoint
{
    internal static RouteHandlerBuilder MapGetEquipmentDepartmentListEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints.MapPost("/search", async (ISender mediator, [FromBody] PaginationFilter filter) =>
        {
            var response = await mediator.Send(new GetEquipmentDepartmentListRequest(filter));
            return Results.Ok(response);
        })
        .WithName(nameof(GetEquipmentDepartmentListEndpoint))
        .WithSummary("Gets a list of EquipmentDepartment items with paging support")
        .WithDescription("Gets a list of EquipmentDepartment items with paging support")
        .Produces<PagedList<EquipmentDepartmentDto>>()
        .RequirePermission("Permissions.LookupCategories.View")
        .MapToApiVersion(1);
    }
}
