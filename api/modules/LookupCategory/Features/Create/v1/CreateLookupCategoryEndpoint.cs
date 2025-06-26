using Asp.Versioning;
using FSH.Framework.Infrastructure.Auth.Policy;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.LookupCategory.Features.Create.v1;
public static class CreateLookupCategoryEndpoint
{
    internal static RouteHandlerBuilder MapLookupCategoryItemCreationEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints.MapPost("/", async (CreateLookupCategoryCommand request, ISender mediator) =>
                {
                    var response = await mediator.Send(request);
                    return Results.CreatedAtRoute(nameof(CreateLookupCategoryEndpoint), new { id = response.Id }, response);
                })
                .WithName(nameof(CreateLookupCategoryEndpoint))
                .WithSummary("Creates a LookupCategory item")
                .WithDescription("Creates a LookupCategory item")
                .Produces<CreateLookupCategoryResponse>(StatusCodes.Status201Created)
                //.RequirePermission("Permissions.LookupCategories.Create")
                .MapToApiVersion(new ApiVersion(1, 0));

    }
}
