using Asp.Versioning;
using FSH.Framework.Infrastructure.Auth.Policy;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.ProjectFundingSource.Features.Create.v1;
public static class CreateProjectFundingSourceEndpoint
{
    internal static RouteHandlerBuilder MapProjectFundingSourceItemCreationEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints.MapPost("/", async (CreateProjectFundingSourceCommand request, ISender mediator) =>
                {
                    var response = await mediator.Send(request);
                    return Results.CreatedAtRoute(nameof(CreateProjectFundingSourceEndpoint), new { id = response.Id }, response);
                })
                .WithName(nameof(CreateProjectFundingSourceEndpoint))
                .WithSummary("Creates a ProjectFundingSource item")
                .WithDescription("Creates a ProjectFundingSource item")
                .Produces<CreateProjectFundingSourceResponse>(StatusCodes.Status201Created)
                .RequirePermission("Permissions.LookupCategories.Create")
                .MapToApiVersion(new ApiVersion(1, 0));

    }
}
