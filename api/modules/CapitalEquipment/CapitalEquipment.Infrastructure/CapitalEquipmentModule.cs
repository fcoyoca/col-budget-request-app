using Carter;
using FSH.Framework.Core.Persistence;
using FSH.Framework.Infrastructure.Persistence;
using budget_request_app.WebApi.CapitalEquipment.Domain;
using budget_request_app.WebApi.CapitalEquipment.Infrastructure.Endpoints.v1.CapitalEquipments;
using budget_request_app.WebApi.CapitalEquipment.Infrastructure.Persistence;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using PastFunding = budget_request_app.WebApi.CapitalProject.Domain.PastFunding;

namespace budget_request_app.WebApi.CapitalEquipment.Infrastructure;
public static class CapitalEquipmentModule
{
    public class Endpoints : CarterModule
    {
        public Endpoints() { }
        public override void AddRoutes(IEndpointRouteBuilder app)
        {
            var capitalEquipmentGroup = app.MapGroup("capitalEquipments").WithTags("Capital Equipment");
            capitalEquipmentGroup.MapCapitalEquipmentCreationEndpoint();
            capitalEquipmentGroup.MapGetCapitalEquipmentEndpoint();
            capitalEquipmentGroup.MapGetCapitalEquipmentListEndpoint();
            capitalEquipmentGroup.MapCapitalEquipmentUpdateEndpoint();
            capitalEquipmentGroup.MapCapitalEquipmentDeleteEndpoint();
            capitalEquipmentGroup.MapCapitalEquipmentUpdateStatusEndpoint();
            capitalEquipmentGroup.MapGetProjectNumberCapitalEquipmentEndpoint();
        }
    }
    public static WebApplicationBuilder RegisterCapitalEquipmentServices(this WebApplicationBuilder builder)
    {
        ArgumentNullException.ThrowIfNull(builder);
        builder.Services.BindDbContext<CapitalEquipmentDbContext>();
        builder.Services.AddScoped<IDbInitializer, CapitalEquipmentDbInitializer>();
        
        builder.Services.AddKeyedScoped<IRepository<CapitalEquipmentItem>, CapitalEquipmentRepository<CapitalEquipmentItem>>("capitalEquipments");
        builder.Services.AddKeyedScoped<IReadRepository<CapitalEquipmentItem>, CapitalEquipmentRepository<CapitalEquipmentItem>>("capitalEquipments");
        
        // builder.Services.AddKeyedScoped<IRepository<budget_request_app.WebApi.CapitalEquipment.Domain.PastFunding>, CapitalEquipmentRepository<budget_request_app.WebApi.CapitalEquipment.Domain.PastFunding>>("capitalEquipmentsPastFundings");
        // builder.Services.AddKeyedScoped<IReadRepository<budget_request_app.WebApi.CapitalEquipment.Domain.PastFunding>, CapitalEquipmentRepository<budget_request_app.WebApi.CapitalEquipment.Domain.PastFunding>>("capitalEquipmentsPastFundings");
        //
        builder.Services.AddKeyedScoped<IRepository<FundingItem>, CapitalEquipmentRepository<FundingItem>>("capitalEquipmentsFundingItems");
        builder.Services.AddKeyedScoped<IReadRepository<FundingItem>, CapitalEquipmentRepository<FundingItem>>("capitalEquipmentsFundingItems");
        
        return builder;
    }
    public static WebApplication UseCapitalEquipmentModule(this WebApplication app)
    {
        return app;
    }
}
