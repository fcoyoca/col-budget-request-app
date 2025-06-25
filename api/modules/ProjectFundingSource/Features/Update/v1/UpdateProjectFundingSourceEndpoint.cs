using Asp.Versioning;
using FSH.Framework.Infrastructure.Auth.Policy;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.ProjectFundingSource.Features.Update.v1;
public static class UpdateProjectFundingSourceEndpoint
{
    internal static RouteHandlerBuilder MapProjectFundingSourceItemUpdationEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints.
            MapPut("/{id:guid}", async (Guid id, UpdateProjectFundingSourceCommand request, ISender mediator) =>
            {
                if (id != request.Id) return Results.BadRequest();
                var response = await mediator.Send(request);
                return Results.Ok(response);
            })
            .WithName(nameof(UpdateProjectFundingSourceEndpoint))
            .WithSummary("Updates a ProjectFundingSource item")
            .WithDescription("Updated a ProjectFundingSource item")
            .Produces<UpdateProjectFundingSourceResponse>(StatusCodes.Status200OK)
            .RequirePermission("Permissions.LookupCategories.Update")
            .MapToApiVersion(new ApiVersion(1, 0));

    }
}
