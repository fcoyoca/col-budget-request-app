using Asp.Versioning;
using FSH.Framework.Infrastructure.Auth.Policy;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.LookupValue.Features.LookupValues.Create.v1;
public static class CreateLookupValueEndpoint
{
    internal static RouteHandlerBuilder MapLookupValueItemCreationEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints.MapPost("/", async (CreateLookupValueCommand request, ISender mediator) =>
                {
                    var response = await mediator.Send(request);
                    return Results.CreatedAtRoute(nameof(CreateLookupValueEndpoint), new { id = response.Id }, response);
                })
                .WithName(nameof(CreateLookupValueEndpoint))
                .WithSummary("Creates a LookupValue item")
                .WithDescription("Creates a LookupValue item")
                .Produces<CreateLookupValueResponse>(StatusCodes.Status201Created)
                //.RequirePermission("Permissions.LookupCategories.Create")
                .AllowAnonymous()
                .MapToApiVersion(new ApiVersion(1, 0));

    }
}
