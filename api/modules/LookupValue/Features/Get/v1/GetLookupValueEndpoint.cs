using FSH.Framework.Infrastructure.Auth.Policy;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.LookupValue.Features.Get.v1;
public static class GetLookupValueEndpoint
{
    internal static RouteHandlerBuilder MapGetLookupValueEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints.MapGet("/{id:guid}", async (Guid id, ISender mediator) =>
                        {
                            var response = await mediator.Send(new GetLookupValueRequest(id));
                            return Results.Ok(response);
                        })
                        .WithName(nameof(GetLookupValueEndpoint))
                        .WithSummary("gets LookupValue item by id")
                        .WithDescription("gets LookupValue item by id")
                        .Produces<GetLookupValueResponse>()
                        //.RequirePermission("Permissions.LookupCategories.View")
                        .MapToApiVersion(1);
    }
}
