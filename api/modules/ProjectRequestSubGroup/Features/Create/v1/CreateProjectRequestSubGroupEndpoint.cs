using Asp.Versioning;
using FSH.Framework.Infrastructure.Auth.Policy;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.ProjectRequestSubGroup.Features.Create.v1;
public static class CreateProjectRequestSubGroupEndpoint
{
    internal static RouteHandlerBuilder MapProjectRequestSubGroupItemCreationEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints.MapPost("/", async (CreateProjectRequestSubGroupCommand request, ISender mediator) =>
                {
                    var response = await mediator.Send(request);
                    return Results.CreatedAtRoute(nameof(CreateProjectRequestSubGroupEndpoint), new { id = response.Id }, response);
                })
                .WithName(nameof(CreateProjectRequestSubGroupEndpoint))
                .WithSummary("Creates a ProjectRequestSubGroup item")
                .WithDescription("Creates a ProjectRequestSubGroup item")
                .Produces<CreateProjectRequestSubGroupResponse>(StatusCodes.Status201Created)
                .RequirePermission("Permissions.LookupCategories.Create")
                .MapToApiVersion(new ApiVersion(1, 0));

    }
}
