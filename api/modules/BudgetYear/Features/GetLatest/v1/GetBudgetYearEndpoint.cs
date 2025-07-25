using budget_request_app.Shared.Authorization;
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
        string requirePermission = FshPermission.NameFor(FshActions.View, FshResources.BudgetYears);
        string[] additionalPermissions = [
            FshPermission.NameFor(FshActions.View, FshResources.CapitalEquipments),
            FshPermission.NameFor(FshActions.View, FshResources.CapitalProjects)
        ];
        return endpoints.MapGet("/latest", async (ISender mediator) =>
                        {
                            var response = await mediator.Send(new GetBudgetYearRequest());
                            return Results.Ok(response);
                        })
                        .WithName(nameof(GetBudgetYearEndpoint))
                        .WithSummary("gets latest BudgetYear")
                        .WithDescription("gets latest BudgetYear")
                        .Produces<GetBudgetYearResponse>()
                        .RequirePermission(requirePermission, additionalPermissions)
                        .AllowAnonymous()
                        .MapToApiVersion(1);
    }
}
