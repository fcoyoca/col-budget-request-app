using Asp.Versioning;
using FSH.Framework.Infrastructure.Auth.Policy;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using ISender = MediatR.ISender;

namespace budget_request_app.WebApi.FileService.Features.Create.v1;
public static class CreateFileServiceEndpoint
{
    internal static RouteHandlerBuilder MapFileServiceItemCreationEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints.MapPost("/", async (HttpRequest request, ISender mediator) =>
            {
                var payload = new CreateFileServiceItemCommand(request);
                var response = await mediator.Send(payload);
                
                return Results.CreatedAtRoute(nameof(CreateFileServiceEndpoint), new { id = response.Id }, response);
            })
            .Accepts<HttpRequest>("multipart/form-data")
            .WithName(nameof(CreateFileServiceEndpoint))
            .WithSummary("Creates a FileService item")
            .WithDescription("Creates a FileService item")
            .Produces<CreateFileServiceItemResponse>(StatusCodes.Status201Created)
            .RequirePermission("Permissions.FileServices.Create")
            .MapToApiVersion(new ApiVersion(1, 0));

    }
}
