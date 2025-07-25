using Asp.Versioning;
using budget_request_app.Shared.Authorization;
using FSH.Framework.Infrastructure.Auth.Policy;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.BudgetYear.Features.Create.v1;
public static class CreateBudgetYearEndpoint
{
    internal static RouteHandlerBuilder MapBudgetYearItemCreationEndpoint(this IEndpointRouteBuilder endpoints)
    {
        string requirePermission = FshPermission.NameFor(FshActions.Create, FshResources.Cutover);
        //string[] additionalPermissions = [
        //    FshPermission.NameFor(FshActions.Create, FshResources.CapitalEquipments),
        //    FshPermission.NameFor(FshActions.Create, FshResources.CapitalProjects)
        //];

        return endpoints.MapPost("/", async (CreateBudgetYearCommand request, ISender mediator) =>
                {
                    var response = await mediator.Send(request);
                    return Results.CreatedAtRoute(nameof(CreateBudgetYearEndpoint), new { id = response.Id }, response);
                })
                .WithName(nameof(CreateBudgetYearEndpoint))
                .WithSummary("Creates a BudgetYear item")
                .WithDescription("Creates a BudgetYear item")
                .Produces<CreateBudgetYearResponse>(StatusCodes.Status201Created)
                .RequirePermission(requirePermission)
                .AllowAnonymous()
                .MapToApiVersion(new ApiVersion(1, 0));

    }
}
