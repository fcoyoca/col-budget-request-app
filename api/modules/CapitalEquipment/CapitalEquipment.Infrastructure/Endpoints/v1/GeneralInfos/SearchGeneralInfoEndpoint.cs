using FSH.Framework.Core.Paging;
using FSH.Framework.Infrastructure.Auth.Policy;
using budget_request_app.WebApi.CapitalEquipment.Application.GeneralInfos.Get.v1;
using budget_request_app.WebApi.CapitalEquipment.Application.GeneralInfos.Search.v1;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.CapitalEquipment.Infrastructure.Endpoints.v1;

public static class SearchGeneralInfosEndpoint
{
    internal static RouteHandlerBuilder MapGetGeneralInfoListEndpoint(this IEndpointRouteBuilder endpoints)
    {
        return endpoints
            .MapPost("/search", async (ISender mediator, [FromBody] SearchGeneralInfosCommand command) =>
            {
                var response = await mediator.Send(command);
                return Results.Ok(response);
            })
            .WithName(nameof(SearchGeneralInfosEndpoint))
            .WithSummary("Gets a list of GeneralInfos")
            .WithDescription("Gets a list of GeneralInfos with pagination and filtering support")
            .Produces<PagedList<GetGeneralInfoResponse>>()
            .RequirePermission("Permissions.GeneralInfos.View")
            .MapToApiVersion(1);
    }
}

