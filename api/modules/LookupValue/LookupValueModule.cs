using Carter;
using FSH.Framework.Core.Persistence;
using FSH.Framework.Infrastructure.Persistence;
using budget_request_app.WebApi.LookupValue.Domain;
using budget_request_app.WebApi.LookupValue.Features.Create.v1;
using budget_request_app.WebApi.LookupValue.Features.Delete.v1;
using budget_request_app.WebApi.LookupValue.Features.Get.v1;
using budget_request_app.WebApi.LookupValue.Features.GetList.v1;
using budget_request_app.WebApi.LookupValue.Features.Update.v1;
using budget_request_app.WebApi.LookupValue.Features.Activate.v1;
using budget_request_app.WebApi.LookupValue.Features.Deactivate.v1;
using budget_request_app.WebApi.LookupValue.Persistence;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;

namespace budget_request_app.WebApi.LookupValue;
public static class LookupValueModule
{

    public class Endpoints : CarterModule
    {
        public override void AddRoutes(IEndpointRouteBuilder app)
        {
            var LookupValueGroup = app.MapGroup("lookupValues").WithTags("lookupValues");
            LookupValueGroup.MapLookupValueItemCreationEndpoint();
            LookupValueGroup.MapGetLookupValueEndpoint();
            LookupValueGroup.MapGetLookupValueListEndpoint();
            LookupValueGroup.MapLookupValueItemUpdationEndpoint();
            LookupValueGroup.MapLookupValueItemActivationEndpoint();
            LookupValueGroup.MapLookupValueItemDeactivationEndpoint();
            LookupValueGroup.MapLookupValueItemDeletionEndpoint();
        }
    }
    public static WebApplicationBuilder RegisterLookupValueServices(this WebApplicationBuilder builder)
    {
        ArgumentNullException.ThrowIfNull(builder);
        builder.Services.BindDbContext<LookupValueDbContext>();
        builder.Services.AddScoped<IDbInitializer, LookupValueDbInitializer>();
        builder.Services.AddKeyedScoped<IRepository<LookupValueItem>, LookupValueRepository<LookupValueItem>>("lookupValues");
        builder.Services.AddKeyedScoped<IReadRepository<LookupValueItem>, LookupValueRepository<LookupValueItem>>("lookupValues");
        return builder;
    }
    public static WebApplication UseLookupValueModule(this WebApplication app)
    {
        return app;
    }
}
