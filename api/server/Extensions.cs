using System.Reflection;
using Asp.Versioning.Conventions;
using budget_request_app.WebApi.LookupCategory;
using budget_request_app.WebApi.LookupValue;
using budget_request_app.WebApi.BudgetYear;
using budget_request_app.WebApi.CapitalEquipment.Infrastructure;
using budget_request_app.WebApi.CapitalProject.Infrastructure;
using budget_request_app.WebApi.FileService;
using Carter;
using FluentValidation;
using FSH.Framework.Core.Persistence;
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
            typeof(CapitalProjectModule).Assembly,
            typeof(FileServiceModule).Assembly,
            typeof(BudgetYearModule).Assembly,
        };

        //register validators
        builder.Services.AddValidatorsFromAssemblies(assemblies);

        //register mediatr
        builder.Services.AddMediatR(cfg =>
        {
            cfg.RegisterServicesFromAssemblies(assemblies);
        });

        //register module services
        builder.RegisterLookupCategoryServices();
        builder.RegisterLookupValueServices();
        builder.RegisterCapitalEquipmentServices();
        builder.RegisterCapitalProjectServices();
        builder.RegisterFileServiceServices();
        builder.RegisterBudgetYearServices();

        //add carter endpoint modules
        builder.Services.AddCarter(configurator: config =>
        {
            config.WithModule<LookupCategoryModule.Endpoints>();
            config.WithModule<LookupValueModule.Endpoints>();
            config.WithModule<CapitalEquipmentModule.Endpoints>();
            config.WithModule<CapitalProjectModule.Endpoints>();
            config.WithModule<FileServiceModule.Endpoints>();
            config.WithModule<BudgetYearModule.Endpoints>();
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
        app.UseCapitalProjectModule();
        app.UseFileServiceModule();
        app.UseBudgetYearModule();

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
    
    public static IApplicationBuilder SetDefaultWebApiContent(this WebApplication app, IConfiguration configuration)
    {
        // Retrieve the WebApiBuildVersion from the configuration
        var buildVersion = configuration["WebApiBuildVersion"] ?? "Version Not Set";

        // Get the environment name (e.g., Development, Staging, Production)
        var environmentName = app.Environment.EnvironmentName;

        // Determine content based on the environment
        var appVersion = environmentName.Contains("dev", StringComparison.InvariantCultureIgnoreCase)
            ? $"Version: {DateTime.UtcNow:yyyy-MM-dd.Hmm}"  // Use current timestamp in dev environment
            : $"Version: {buildVersion}";

        // Map the root URL ("/") to return the app version information
        app.MapGet("/", () => appVersion);

        return app;
    }
}
