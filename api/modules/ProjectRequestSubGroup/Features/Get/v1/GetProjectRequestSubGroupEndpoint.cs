using budget_request_app.WebApi.ProjectRequestSubGroup.Features.Get.v1;
using budget_request_app.WebApi.ProjectRequestSubGroup.Features.Get.v1;
using FSH.Framework.Infrastructure.Auth.Policy;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.ProjectRequestSubGroup.Features.Get.v1;
public static class GetProjectRequestSubGroupEndpoint
{
    internal static RouteHandlerBuilder MapGetProjectRequestSubGroupEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints.MapGet("/{id:guid}", async (Guid id, ISender mediator) =>
                        {
                            var response = await mediator.Send(new GetProjectRequestSubGroupRequest(id));
                            return Results.Ok(response);
                        })
                        .WithName(nameof(GetProjectRequestSubGroupEndpoint))
                        .WithSummary("gets ProjectRequestSubGroup item by id")
                        .WithDescription("gets ProjectRequestSubGroup item by id")
                        .Produces<GetProjectRequestSubGroupResponse>()
                        .RequirePermission("Permissions.LookupCategories.View")
                        .MapToApiVersion(1);
    }
}
