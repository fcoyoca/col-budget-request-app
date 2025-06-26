using FSH.Framework.Infrastructure.Auth.Policy;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.LookupCategory.Features.Get.v1;
public static class GetLookupCategoryEndpoint
{
    internal static RouteHandlerBuilder MapGetLookupCategoryEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints.MapGet("/{id:guid}", async (Guid id, ISender mediator) =>
                        {
                            var response = await mediator.Send(new GetLookupCategoryRequest(id));
                            return Results.Ok(response);
                        })
                        .WithName(nameof(GetLookupCategoryEndpoint))
                        .WithSummary("gets LookupCategory item by id")
                        .WithDescription("gets LookupCategory item by id")
                        .Produces<GetLookupCategoryResponse>()
                        //.RequirePermission("Permissions.LookupCategories.View")
                        .AllowAnonymous()
                        .MapToApiVersion(1);
    }
}
