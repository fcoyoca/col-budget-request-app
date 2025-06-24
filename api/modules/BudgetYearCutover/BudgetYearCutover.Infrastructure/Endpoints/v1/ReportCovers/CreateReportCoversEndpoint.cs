using BudgetYearCutover.Infrastructure.SubModules.ReportCovers.Create.v1;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace BudgetYearCutover.Infrastructure.Endpoints.v1.ReportCovers;

public static class CreateReportCoversEndpoint
{
    public static RouteHandlerBuilder MapReportCoversEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints
            .MapPost("/", async (CreateCutoverReportCommand request, ISender mediator) =>
            {
                var response = await mediator.Send(request);
                return Results.Ok(response);
            })
            .WithName(nameof(CreateReportCoversEndpoint))
            .WithSummary("upload report covers")
            .WithDescription("upload report covers")
            .Produces<CreateCutoverReportResponse>()
            .MapToApiVersion(1);
    }
}
