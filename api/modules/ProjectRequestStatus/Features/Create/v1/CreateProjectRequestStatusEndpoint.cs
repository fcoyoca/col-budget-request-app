using Asp.Versioning;
using FSH.Framework.Infrastructure.Auth.Policy;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.ProjectRequestStatus.Features.Create.v1;
public static class CreateProjectRequestStatusEndpoint
{
    internal static RouteHandlerBuilder MapProjectRequestStatusItemCreationEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints.MapPost("/", async (CreateProjectRequestStatusCommand request, ISender mediator) =>
                {
                    var response = await mediator.Send(request);
                    return Results.CreatedAtRoute(nameof(CreateProjectRequestStatusEndpoint), new { id = response.Id }, response);
                })
                .WithName(nameof(CreateProjectRequestStatusEndpoint))
                .WithSummary("Creates a ProjectRequestStatus item")
                .WithDescription("Creates a ProjectRequestStatus item")
                .Produces<CreateProjectRequestStatusResponse>(StatusCodes.Status201Created)
                .RequirePermission("Permissions.LookupCategories.Create")
                .MapToApiVersion(new ApiVersion(1, 0));

    }
}
