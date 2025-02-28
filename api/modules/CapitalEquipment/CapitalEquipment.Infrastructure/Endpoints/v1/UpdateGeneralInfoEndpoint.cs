using FSH.Framework.Infrastructure.Auth.Policy;
using budget_request_app.WebApi.CapitalEquipment.Application.GeneralInfos.Update.v1;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.CapitalEquipment.Infrastructure.Endpoints.v1;
public static class UpdateGeneralInfoEndpoint
{
    internal static RouteHandlerBuilder MapGeneralInfoUpdateEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints
            .MapPut("/{id:guid}", async (Guid id, UpdateGeneralInfoCommand request, ISender mediator) =>
            {
                if (id != request.Id) return Results.BadRequest();
                var response = await mediator.Send(request);
                return Results.Ok(response);
            })
            .WithName(nameof(UpdateGeneralInfoEndpoint))
            .WithSummary("update a GeneralInfo")
            .WithDescription("update a GeneralInfo")
            .Produces<UpdateGeneralInfoResponse>()
            .RequirePermission("Permissions.GeneralInfos.Update")
            .MapToApiVersion(1);
    }
}
