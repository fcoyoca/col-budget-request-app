using FSH.Framework.Infrastructure.Auth.Policy;
using budget_request_app.WebApi.CapitalEquipment.Application.GeneralInfos.Delete.v1;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.CapitalEquipment.Infrastructure.Endpoints.v1;
public static class DeleteGeneralInfoEndpoint
{
    internal static RouteHandlerBuilder MapGeneralInfoDeleteEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints
            .MapDelete("/{id:guid}", async (Guid id, ISender mediator) =>
             {
                 await mediator.Send(new DeleteGeneralInfoCommand(id));
                 return Results.NoContent();
             })
            .WithName(nameof(DeleteGeneralInfoEndpoint))
            .WithSummary("deletes GeneralInfo by id")
            .WithDescription("deletes GeneralInfo by id")
            .Produces(StatusCodes.Status204NoContent)
            .RequirePermission("Permissions.GeneralInfos.Delete")
            .MapToApiVersion(1);
    }
}
