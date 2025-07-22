using budget_request_app.WebApi.ProjectRequestStatus.Features.Get.v1;
using budget_request_app.WebApi.ProjectRequestStatus.Features.Get.v1;
using FSH.Framework.Infrastructure.Auth.Policy;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.ProjectRequestStatus.Features.Get.v1;
public static class GetProjectRequestStatusEndpoint
{
    internal static RouteHandlerBuilder MapGetProjectRequestStatusEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints.MapGet("/{id:guid}", async (Guid id, ISender mediator) =>
                        {
                            var response = await mediator.Send(new GetProjectRequestStatusRequest(id));
                            return Results.Ok(response);
                        })
                        .WithName(nameof(GetProjectRequestStatusEndpoint))
                        .WithSummary("gets ProjectRequestStatus item by id")
                        .WithDescription("gets ProjectRequestStatus item by id")
                        .Produces<GetProjectRequestStatusResponse>()
                        .RequirePermission("Permissions.LookupCategories.View")
                        .MapToApiVersion(1);
    }
}
