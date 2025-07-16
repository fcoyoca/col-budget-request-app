using Carter;
using FSH.Framework.Core.Persistence;
using FSH.Framework.Infrastructure.Persistence;
using budget_request_app.WebApi.EquipmentFundingSource.Domain;
using budget_request_app.WebApi.EquipmentFundingSource.Features.Create.v1;
using budget_request_app.WebApi.EquipmentFundingSource.Features.Delete.v1;
using budget_request_app.WebApi.EquipmentFundingSource.Features.Get.v1;
using budget_request_app.WebApi.EquipmentFundingSource.Features.GetList.v1;
using budget_request_app.WebApi.EquipmentFundingSource.Features.Update.v1;
using budget_request_app.WebApi.EquipmentFundingSource.Features.Activate.v1;
using budget_request_app.WebApi.EquipmentFundingSource.Features.Deactivate.v1;
using budget_request_app.WebApi.EquipmentFundingSource.Persistence;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;

namespace budget_request_app.WebApi.EquipmentFundingSource;
public static class EquipmentFundingSourceModule
{
    public class Endpoints : CarterModule
    {
        public override void AddRoutes(IEndpointRouteBuilder app)
        {
            var EquipmentFundingSourceGroup = app.MapGroup("EquipmentFundingSources").WithTags("Equipment Funding Source Values");
            EquipmentFundingSourceGroup.MapEquipmentFundingSourceItemCreationEndpoint();
            EquipmentFundingSourceGroup.MapGetEquipmentFundingSourceEndpoint();
            EquipmentFundingSourceGroup.MapGetEquipmentFundingSourceListEndpoint();
            EquipmentFundingSourceGroup.MapEquipmentFundingSourceItemUpdationEndpoint();
            EquipmentFundingSourceGroup.MapEquipmentFundingSourceItemActivationEndpoint();
            EquipmentFundingSourceGroup.MapEquipmentFundingSourceItemDeactivationEndpoint();
            EquipmentFundingSourceGroup.MapEquipmentFundingSourceItemDeletionEndpoint();
        }
    }
    public static WebApplicationBuilder RegisterEquipmentFundingSourceServices(this WebApplicationBuilder builder)
    {
        ArgumentNullException.ThrowIfNull(builder);
        builder.Services.BindDbContext<EquipmentFundingSourceDbContext>();
        builder.Services.AddScoped<IDbInitializer, EquipmentFundingSourceDbInitializer>();
        builder.Services.AddKeyedScoped<IRepository<EquipmentFundingSourceItem>, EquipmentFundingSourceRepository<EquipmentFundingSourceItem>>("EquipmentFundingSources");
        builder.Services.AddKeyedScoped<IReadRepository<EquipmentFundingSourceItem>, EquipmentFundingSourceRepository<EquipmentFundingSourceItem>>("EquipmentFundingSources");
        return builder;
    }
    public static WebApplication UseEquipmentFundingSourceModule(this WebApplication app)
    {
        return app;
    }
}
