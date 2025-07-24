using budget_request_app.WebApi.ProjectRequestGroup.Features.Get.v1;
using FSH.Framework.Infrastructure.Auth.Policy;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.ProjectRequestGroup.Features.Get.v1;
public static class GetProjectRequestGroupEndpoint
{
    internal static RouteHandlerBuilder MapGetProjectRequestGroupEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints.MapGet("/{id:guid}", async (Guid id, ISender mediator) =>
                        {
                            var response = await mediator.Send(new GetProjectRequestGroupRequest(id));
                            return Results.Ok(response);
                        })
                        .WithName(nameof(GetProjectRequestGroupEndpoint))
                        .WithSummary("gets ProjectRequestGroup item by id")
                        .WithDescription("gets ProjectRequestGroup item by id")
                        .Produces<GetProjectRequestGroupResponse>()
                        .RequirePermission("Permissions.LookupCategories.View")
                        .MapToApiVersion(1);
    }
}
