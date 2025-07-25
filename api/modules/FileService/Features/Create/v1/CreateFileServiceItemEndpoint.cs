using Asp.Versioning;
using budget_request_app.Shared.Authorization;
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
        string requirePermission = FshPermission.NameFor(FshActions.Create, FshResources.FileServices);

        return endpoints.MapPost("/", async (HttpRequest request, ISender mediator,HttpContext context) =>
            {
                var payload = new CreateFileServiceItemCommand(request);
                var response = await mediator.Send(payload);
                
                return Results.Content(response.Id.ToString(), "application/" + response.Id.ToString());
            })
            .Accepts<HttpRequest>("multipart/form-data")
            .WithName(nameof(CreateFileServiceEndpoint))
            .WithSummary("Creates a FileService item")
            .WithDescription("Creates a FileService item")
            .RequirePermission("Permissions.FileServices.Create")
            .MapToApiVersion(new ApiVersion(1, 0));

    }
}
