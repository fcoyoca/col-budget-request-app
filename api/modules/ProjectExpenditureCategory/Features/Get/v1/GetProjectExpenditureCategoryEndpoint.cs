using FSH.Framework.Infrastructure.Auth.Policy;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.ProjectExpenditureCategory.Features.Get.v1;
public static class GetProjectExpenditureCategoryEndpoint
{
    internal static RouteHandlerBuilder MapGetProjectExpenditureCategoryEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints.MapGet("/{id:guid}", async (Guid id, ISender mediator) =>
                        {
                            var response = await mediator.Send(new GetProjectExpenditureCategoryRequest(id));
                            return Results.Ok(response);
                        })
                        .WithName(nameof(GetProjectExpenditureCategoryEndpoint))
                        .WithSummary("gets ProjectExpenditureCategory item by id")
                        .WithDescription("gets ProjectExpenditureCategory item by id")
                        .Produces<GetProjectExpenditureCategoryResponse>()
                        .RequirePermission("Permissions.LookupCategories.View")
                        .MapToApiVersion(1);
    }
}
