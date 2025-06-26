using Asp.Versioning;
using FSH.Framework.Infrastructure.Auth.Policy;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.LookupValue.Features.Update.v1;
public static class UpdateLookupValueEndpoint
{
    internal static RouteHandlerBuilder MapLookupValueItemUpdationEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints.
            MapPut("/{id:guid}", async (Guid id, UpdateLookupValueCommand request, ISender mediator) =>
            {
                if (id != request.Id) return Results.BadRequest();
                var response = await mediator.Send(request);
                return Results.Ok(response);
            })
            .WithName(nameof(UpdateLookupValueEndpoint))
            .WithSummary("Updates a LookupValue item")
            .WithDescription("Updated a LookupValue item")
            .Produces<UpdateLookupValueResponse>(StatusCodes.Status200OK)
            //.RequirePermission("Permissions.LookupCategories.Update")
            .MapToApiVersion(new ApiVersion(1, 0));

    }
}
