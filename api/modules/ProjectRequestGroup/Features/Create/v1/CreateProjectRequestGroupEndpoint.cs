using Asp.Versioning;
using FSH.Framework.Infrastructure.Auth.Policy;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.ProjectRequestGroup.Features.Create.v1;
public static class CreateProjectRequestGroupEndpoint
{
    internal static RouteHandlerBuilder MapProjectRequestGroupItemCreationEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints.MapPost("/", async (CreateProjectRequestGroupCommand request, ISender mediator) =>
                {
                    var response = await mediator.Send(request);
                    return Results.CreatedAtRoute(nameof(CreateProjectRequestGroupEndpoint), new { id = response.Id }, response);
                })
                .WithName(nameof(CreateProjectRequestGroupEndpoint))
                .WithSummary("Creates a ProjectRequestGroup item")
                .WithDescription("Creates a ProjectRequestGroup item")
                .Produces<CreateProjectRequestGroupResponse>(StatusCodes.Status201Created)
                .RequirePermission("Permissions.LookupCategories.Create")
                .MapToApiVersion(new ApiVersion(1, 0));

    }
}
