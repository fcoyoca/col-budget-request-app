using System.Reflection;
using Asp.Versioning.Conventions;
using budget_request_app.WebApi.LookupCategory;
using budget_request_app.WebApi.LookupValue;
using budget_request_app.WebApi.CapitalEquipment.Infrastructure;
using Carter;
using FluentValidation;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace budget_request_app.WebApi.Host;

public static class Extensions
{
    public static WebApplicationBuilder RegisterModules(this WebApplicationBuilder builder)
    {
        ArgumentNullException.ThrowIfNull(builder);

        //define module assemblies
        var assemblies = new Assembly[]
        {
            typeof(LookupCategoryModule).Assembly,
            typeof(LookupValueModule).Assembly,
            typeof(CapitalEquipmentModule).Assembly,
        };

        //register validators
        builder.Services.AddValidatorsFromAssemblies(assemblies);

        //register mediatr
        builder.Services.AddMediatR(cfg =>
        {
            cfg.RegisterServicesFromAssemblies(assemblies);
        });

        foreach (var s in builder.Services.Where(x => x.ServiceType.FullName.Contains("Command,") && x.ServiceType.FullName.Contains("IRequestHandler")))
        {
            Console.WriteLine(s.ServiceType.ShortDisplayName());
        }

        //register module services
        builder.RegisterLookupCategoryServices();
        builder.RegisterLookupValueServices();
        builder.RegisterCapitalEquipmentServices();

        //add carter endpoint modules
        builder.Services.AddCarter(configurator: config =>
        {
            config.WithModule<LookupCategoryModule.Endpoints>();
            config.WithModule<LookupValueModule.Endpoints>();
            config.WithModule<CapitalEquipmentModule.Endpoints>();
        });
        
        return builder;
    }

    public static WebApplication UseModules(this WebApplication app)
    {
        ArgumentNullException.ThrowIfNull(app);

        //register modules
        app.UseLookupCategoryModule();
        app.UseLookupValueModule();
        app.UseCapitalEquipmentModule();

        //register api versions
        var versions = app.NewApiVersionSet()
                    .HasApiVersion(1)
                    .HasApiVersion(2)
                    .ReportApiVersions()
                    .Build();

        //map versioned endpoint
        var endpoints = app.MapGroup("api/v{version:apiVersion}").WithApiVersionSet(versions);

        //use carter
        endpoints.MapCarter();

        return app;
    }
}
