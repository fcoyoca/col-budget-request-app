using budget_request_app.WebApi.LookupValue.Features.Get.v1;
using FSH.Framework.Infrastructure.Auth.Policy;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.BudgetYear.Features.Get.v1;
public static class GetBudgetYearEndpoint
{
    internal static RouteHandlerBuilder MapGetBudgetYearEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints.MapGet("/{id:guid}", async (Guid id, ISender mediator) =>
                        {
                            var response = await mediator.Send(new GetBudgetYearRequest(id));
                            return Results.Ok(response);
                        })
                        .WithName(nameof(GetBudgetYearEndpoint))
                        .WithSummary("gets BudgetYear item by id")
                        .WithDescription("gets BudgetYear item by id")
                        .Produces<GetBudgetYearResponse>()
                        .RequirePermission("Permissions.BudgetYears.View")
                        .MapToApiVersion(1);
    }
}
