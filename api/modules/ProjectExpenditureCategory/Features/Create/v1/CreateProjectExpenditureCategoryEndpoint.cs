using Asp.Versioning;
using FSH.Framework.Infrastructure.Auth.Policy;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.ProjectExpenditureCategory.Features.Create.v1;
public static class CreateProjectExpenditureCategoryEndpoint
{
    internal static RouteHandlerBuilder MapProjectExpenditureCategoryItemCreationEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints.MapPost("/", async (CreateProjectExpenditureCategoryCommand request, ISender mediator) =>
                {
                    var response = await mediator.Send(request);
                    return Results.CreatedAtRoute(nameof(CreateProjectExpenditureCategoryEndpoint), new { id = response.Id }, response);
                })
                .WithName(nameof(CreateProjectExpenditureCategoryEndpoint))
                .WithSummary("Creates a ProjectExpenditureCategory item")
                .WithDescription("Creates a ProjectExpenditureCategory item")
                .Produces<CreateProjectExpenditureCategoryResponse>(StatusCodes.Status201Created)
                .RequirePermission("Permissions.LookupCategories.Create")
                .MapToApiVersion(new ApiVersion(1, 0));

    }
}
