using Asp.Versioning;
using FSH.Framework.Infrastructure.Auth.Policy;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.LookupCategory.Features.Update.v1;
public static class UpdateLookupCategoryEndpoint
{
    internal static RouteHandlerBuilder MapLookupCategoryItemUpdationEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints.
            MapPut("/{id:guid}", async (Guid id, UpdateLookupCategoryCommand request, ISender mediator) =>
            {
                if (id != request.Id) return Results.BadRequest();
                var response = await mediator.Send(request);
                return Results.Ok(response);
            })
            .WithName(nameof(UpdateLookupCategoryEndpoint))
            .WithSummary("Updates a LookupCategory item")
            .WithDescription("Updated a LookupCategory item")
            .Produces<UpdateLookupCategoryResponse>(StatusCodes.Status200OK)
            //.RequirePermission("Permissions.LookupCategorys.Update")
            .MapToApiVersion(new ApiVersion(1, 0));

    }
}
