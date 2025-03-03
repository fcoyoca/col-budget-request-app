using FSH.Framework.Infrastructure.Auth.Policy;
using budget_request_app.WebApi.CapitalEquipment.Application.GeneralInfos.Create.v1;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.CapitalEquipment.Infrastructure.Endpoints.v1;
public static class CreateGeneralInfoEndpoint
{
    internal static RouteHandlerBuilder MapGeneralInfoCreationEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints
            .MapPost("/", async (CreateGeneralInfoCommand request, ISender mediator) =>
            {
                var response = await mediator.Send(request);
                return Results.Ok(response);
            })
            .WithName(nameof(CreateGeneralInfoEndpoint))
            .WithSummary("creates a GeneralInfo")
            .WithDescription("creates a GeneralInfo")
            .Produces<CreateGeneralInfoResponse>()
            .RequirePermission("Permissions.GeneralInfos.Create")
            .MapToApiVersion(1);
    }
}
