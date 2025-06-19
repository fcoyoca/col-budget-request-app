using System.Reflection;
using Asp.Versioning.Conventions;
using budget_request_app.WebApi.LookupCategory;
using budget_request_app.WebApi.LookupValue;
using budget_request_app.WebApi.BudgetYear;
using budget_request_app.WebApi.CapitalEquipment.Infrastructure;
using budget_request_app.WebApi.CapitalProject.Infrastructure;
using budget_request_app.WebApi.FileService;
using budget_request_app.WebApi.ProjectFundingSource;
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
            typeof(ProjectFundingSourceModule).Assembly
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
        builder.RegisterProjectFundingSourceServices();

        //add carter endpoint modules
        builder.Services.AddCarter(configurator: config =>
        {
            config.WithModule<LookupCategoryModule.Endpoints>();
            config.WithModule<LookupValueModule.Endpoints>();
            config.WithModule<CapitalEquipmentModule.Endpoints>();
            config.WithModule<CapitalProjectModule.Endpoints>();
            config.WithModule<FileServiceModule.Endpoints>();
            config.WithModule<BudgetYearModule.Endpoints>();
            config.WithModule<ProjectFundingSourceModule.Endpoints>();
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
        app.UseProjectFundingSourceModule();

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
