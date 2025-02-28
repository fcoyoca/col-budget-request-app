using Carter;
using FSH.Framework.Core.Persistence;
using FSH.Framework.Infrastructure.Persistence;
using budget_request_app.WebApi.CapitalEquipment.Domain;
using budget_request_app.WebApi.CapitalEquipment.Infrastructure.Endpoints.v1;
using budget_request_app.WebApi.CapitalEquipment.Infrastructure.Persistence;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;

namespace budget_request_app.WebApi.CapitalEquipment.Infrastructure;
public static class CapitalEquipmentModule
{
    public class Endpoints : CarterModule
    {
        public Endpoints() : base("capitalEquipment") { }
        public override void AddRoutes(IEndpointRouteBuilder app)
        {
            var generalInfoGroup = app.MapGroup("generalInfos").WithTags("generalInfos");
            generalInfoGroup.MapGeneralInfoCreationEndpoint();
            generalInfoGroup.MapGetGeneralInfoEndpoint();
            generalInfoGroup.MapGetGeneralInfoListEndpoint();
            generalInfoGroup.MapGeneralInfoUpdateEndpoint();
            generalInfoGroup.MapGeneralInfoDeleteEndpoint();
            //
            // var brandGroup = app.MapGroup("brands").WithTags("brands");
            // brandGroup.MapBrandCreationEndpoint();
            // brandGroup.MapGetBrandEndpoint();
            // brandGroup.MapGetBrandListEndpoint();
            // brandGroup.MapBrandUpdateEndpoint();
            // brandGroup.MapBrandDeleteEndpoint();
        }
    }
    public static WebApplicationBuilder RegisterCapitalEquipmentServices(this WebApplicationBuilder builder)
    {
        ArgumentNullException.ThrowIfNull(builder);
        builder.Services.BindDbContext<CapitalEquipmentDbContext>();
        builder.Services.AddScoped<IDbInitializer, CapitalEquipmentDbInitializer>();
        builder.Services.AddKeyedScoped<IRepository<GeneralInfo>, CapitalEquipmentRepository<GeneralInfo>>("capitalEquipment:generalInfos");
        builder.Services.AddKeyedScoped<IReadRepository<GeneralInfo>, CapitalEquipmentRepository<GeneralInfo>>("capitalEquipment:generalInfos");
        // builder.Services.AddKeyedScoped<IRepository<Brand>, CatalogRepository<Brand>>("catalog:brands");
        // builder.Services.AddKeyedScoped<IReadRepository<Brand>, CatalogRepository<Brand>>("catalog:brands");
        return builder;
    }
    public static WebApplication UseCapitalEquipmentModule(this WebApplication app)
    {
        return app;
    }
}
