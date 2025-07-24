using System.Reflection;
using Asp.Versioning.Conventions;
using budget_request_app.WebApi.BudgetYear;
using budget_request_app.WebApi.CapitalEquipment.Infrastructure;
using budget_request_app.WebApi.CapitalProject.Infrastructure;
using budget_request_app.WebApi.EquipmentDepartment;
using budget_request_app.WebApi.EquipmentFundingSource;
using budget_request_app.WebApi.FileService;
using budget_request_app.WebApi.LookupCategory;
using budget_request_app.WebApi.LookupValue;
using budget_request_app.WebApi.ProjectFundingSource;
using budget_request_app.WebApi.EquipmentDepartment;
using budget_request_app.WebApi.ProjectExpenditureCategory;
using BudgetYearCutover.Infrastructure;
using Carter;
using FluentValidation;
using budget_request_app.WebApi.ProjectRequestGroup;
using budget_request_app.WebApi.ProjectRequestSubGroup;
using budget_request_app.WebApi.ProjectRequestStatus;
using budget_request_app.WebApi.ProjectBudgetIntroSectionOutlineItem;



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
            typeof(ProjectFundingSourceModule).Assembly,
            typeof(EquipmentFundingSourceModule).Assembly,
            typeof(BudgetYearCutoverModule).Assembly,
            typeof(EquipmentDepartmentModule).Assembly,
            typeof(ProjectExpenditureCategoryModule).Assembly,
            typeof(ProjectRequestGroupModule).Assembly,
            typeof(ProjectRequestSubGroupModule).Assembly,
            typeof(ProjectRequestStatusModule).Assembly,
            typeof(ProjectBudgetIntroSectionOutlineItemModule).Assembly,
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
        builder.RegisterEquipmentFundingSourceServices();
        builder.RegisterBudgetYearCutoverServices();
        builder.RegisterEquipmentDepartmentServices();
        builder.RegisterProjectExpenditureCategoryServices();
        builder.RegisterProjectRequestGroupServices();
        builder.RegisterProjectRequestSubGroupServices();
        builder.RegisterProjectRequestStatusServices();
        builder.RegisterProjectBudgetIntroSectionOutlineItemServices();

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
            config.WithModule<EquipmentFundingSourceModule.Endpoints>();
            config.WithModule<BudgetYearCutoverModule.Endpoints>();
            config.WithModule<EquipmentDepartmentModule.Endpoints>();
            config.WithModule<ProjectExpenditureCategoryModule.Endpoints>();
            config.WithModule<ProjectRequestGroupModule.Endpoints>();
            config.WithModule<ProjectRequestSubGroupModule.Endpoints>();
            config.WithModule<ProjectRequestStatusModule.Endpoints>();
            config.WithModule<ProjectBudgetIntroSectionOutlineItemModule.Endpoints>();
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
        app.UseEquipmentFundingSourceModule();
        app.UseBudgetYearCutoverModule();
        app.UseEquipmentDepartmentModule();
        app.UseProjectExpenditureCategoryModule();
        app.UseProjectRequestGroupModule();
        app.UseProjectRequestSubGroupModule();
        app.UseProjectRequestStatusModule();
        app.UseProjectBudgetIntroSectionOutlineItemModule();

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
            : $"Version: {DateTime.UtcNow:yyyy-MM-dd.Hmm}.{buildVersion}";

        // Map the root URL ("/") to return the app version information
        app.MapGroup("buildversion")
            .WithName("build version")
            .WithSummary("get current build version")
            .MapGet("/", () => appVersion)
            .WithTags("Build Version");

        return app;
    }
}
