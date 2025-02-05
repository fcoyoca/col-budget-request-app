using System.Reflection;
using Asp.Versioning.Conventions;
using budget_request_app.WebApi.Todo;
using budget_request_app.WebApi.LookupCategory;
using Carter;
using FluentValidation;

namespace budget_request_app.WebApi.Host;

public static class Extensions
{
    public static WebApplicationBuilder RegisterModules(this WebApplicationBuilder builder)
    {
        ArgumentNullException.ThrowIfNull(builder);

        //define module assemblies
        var assemblies = new Assembly[]
        {
            // typeof(CatalogMetadata).Assembly, // TODO: remove existing service for reference
            typeof(TodoModule).Assembly,
            typeof(LookupCategoryModule).Assembly
            //typeof(LookupCategoryModule).Assembly
        };

        //register validators
        builder.Services.AddValidatorsFromAssemblies(assemblies);

        //register mediatr
        builder.Services.AddMediatR(cfg =>
        {
            cfg.RegisterServicesFromAssemblies(assemblies);
        });

        //register module services
        // builder.RegisterCatalogServices(); // TODO: remove existing service for reference
        builder.RegisterTodoServices();
        builder.RegisterLookupCategoryServices();

        //add carter endpoint modules
        builder.Services.AddCarter(configurator: config =>
        {
            // config.WithModule<CatalogModule.Endpoints>(); // TODO: remove existing service for reference
            config.WithModule<TodoModule.Endpoints>();
            config.WithModule<LookupCategoryModule.Endpoints>();
        });

        return builder;
    }

    public static WebApplication UseModules(this WebApplication app)
    {
        ArgumentNullException.ThrowIfNull(app);

        //register modules
        // app.UseCatalogModule(); // TODO: remove existing service for reference
        app.UseTodoModule();
        app.UseLookupCategoryModule();

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
