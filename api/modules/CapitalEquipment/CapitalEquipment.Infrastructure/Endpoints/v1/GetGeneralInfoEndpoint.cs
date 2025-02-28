using FSH.Framework.Infrastructure.Auth.Policy;
using budget_request_app.WebApi.CapitalEquipment.Application.GeneralInfos.Get.v1;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.CapitalEquipment.Infrastructure.Endpoints.v1;
public static class GetGeneralInfoEndpoint
{
    internal static RouteHandlerBuilder MapGetGeneralInfoEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints
            .MapGet("/{id:guid}", async (Guid id, ISender mediator) =>
            {
                var response = await mediator.Send(new GetGeneralInfoRequest(id));
                return Results.Ok(response);
            })
            .WithName(nameof(GetGeneralInfoEndpoint))
            .WithSummary("gets GeneralInfo by id")
            .WithDescription("gets prodct by id")
            .Produces<GeneralInfoResponse>()
            .RequirePermission("Permissions.GeneralInfos.View")
            .MapToApiVersion(1);
    }
}
