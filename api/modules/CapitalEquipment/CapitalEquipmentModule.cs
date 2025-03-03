using Carter;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace budget_request_app.WebApi.CapitalEquipment;

public static class CapitalEquipmentModule
{
    public Endpoints() : base("capitalEquipment") { }
    public override void AddRoutes(IEndpointRouteBuilder app)
    {
        var generalInfoGroup = app.MapGroup("generalInfos").WithTags("General Information");
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

    // foreach(var service in builder.Services)
    // {
    //     Console.WriteLine($"Service: {service.ServiceType.FullName}");
    //     // \nLifetime: {service.Lifetime}
    //     // \nInstance: {service.ImplementationType?.FullName}");
    // }
        
    return builder;
}
public static WebApplication UseCapitalEquipmentModule(this WebApplication app)
{
    return app;
}
}
