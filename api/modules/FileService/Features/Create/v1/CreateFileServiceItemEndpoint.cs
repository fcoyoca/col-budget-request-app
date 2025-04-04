using Asp.Versioning;
using FSH.Framework.Infrastructure.Auth.Policy;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.FileService.Features.Create.v1;
public static class CreateFileServiceEndpoint
{
    internal static RouteHandlerBuilder MapFileServiceItemCreationEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints.MapPost("/", async (CreateFileServiceItemCommand request, ISender mediator, HttpContext context) =>
                {
                    Console.WriteLine("what the file service item was created");
                    var response = await mediator.Send(request);
                    
                    return Results.CreatedAtRoute(nameof(CreateFileServiceEndpoint), new { id = response.Id }, response);
                })
                .WithName(nameof(CreateFileServiceEndpoint))
                .WithSummary("Creates a FileService item")
                .WithDescription("Creates a FileService item")
                .Produces<CreateFileServiceItemResponse>(StatusCodes.Status201Created)
                .RequirePermission("Permissions.FileServices.Create")
                .MapToApiVersion(new ApiVersion(1, 0));

    }
}
