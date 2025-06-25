using FSH.Framework.Infrastructure.Auth.Policy;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.ProjectFundingSource.Features.Get.v1;
public static class GetProjectFundingSourceEndpoint
{
    internal static RouteHandlerBuilder MapGetProjectFundingSourceEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints.MapGet("/{id:guid}", async (Guid id, ISender mediator) =>
                        {
                            var response = await mediator.Send(new GetProjectFundingSourceRequest(id));
                            return Results.Ok(response);
                        })
                        .WithName(nameof(GetProjectFundingSourceEndpoint))
                        .WithSummary("gets ProjectFundingSource item by id")
                        .WithDescription("gets ProjectFundingSource item by id")
                        .Produces<GetProjectFundingSourceResponse>()
                        .RequirePermission("Permissions.LookupCategories.View")
                        .MapToApiVersion(1);
    }
}
