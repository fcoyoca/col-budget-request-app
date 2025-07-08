using Asp.Versioning;
using FSH.Framework.Infrastructure.Auth.Policy;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.EquipmentFundingSource.Features.Create.v1;
public static class CreateEquipmentFundingSourceEndpoint
{
    internal static RouteHandlerBuilder MapEquipmentFundingSourceItemCreationEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints.MapPost("/", async (CreateEquipmentFundingSourceCommand request, ISender mediator) =>
                {
                    var response = await mediator.Send(request);
                    return Results.CreatedAtRoute(nameof(CreateEquipmentFundingSourceEndpoint), new { id = response.Id }, response);
                })
                .WithName(nameof(CreateEquipmentFundingSourceEndpoint))
                .WithSummary("Creates a EquipmentFundingSource item")
                .WithDescription("Creates a EquipmentFundingSource item")
                .Produces<CreateEquipmentFundingSourceResponse>(StatusCodes.Status201Created)
                .RequirePermission("Permissions.LookupCategories.Create")
                .MapToApiVersion(new ApiVersion(1, 0));

    }
}
