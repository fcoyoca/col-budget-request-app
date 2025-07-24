using budget_request_app.WebApi.ProjectExpenditureCategory.Persistence;
using budget_request_app.WebApi.ProjectExpenditureCategory.Domain;
using budget_request_app.WebApi.ProjectExpenditureCategory.Features.Activate.v1;
using budget_request_app.WebApi.ProjectExpenditureCategory.Features.Create.v1;
using budget_request_app.WebApi.ProjectExpenditureCategory.Features.Deactivate.v1;
using budget_request_app.WebApi.ProjectExpenditureCategory.Features.Delete.v1;
using budget_request_app.WebApi.ProjectExpenditureCategory.Features.Get.v1;
using budget_request_app.WebApi.ProjectExpenditureCategory.Features.GetList.v1;
using budget_request_app.WebApi.ProjectExpenditureCategory.Features.Update.v1;
using budget_request_app.WebApi.ProjectExpenditureCategory.Persistence;
using Carter;
using FSH.Framework.Core.Persistence;
using FSH.Framework.Infrastructure.Persistence;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;

namespace budget_request_app.WebApi.ProjectExpenditureCategory;
public static class ProjectExpenditureCategoryModule
{
    public class Endpoints : CarterModule
    {
        public override void AddRoutes(IEndpointRouteBuilder app)
        {
            var ProjectExpenditureCategoryGroup = app.MapGroup("ProjectExpenditureCategories").WithTags("Project Expenditure Category Values");
            ProjectExpenditureCategoryGroup.MapProjectExpenditureCategoryItemCreationEndpoint();
            ProjectExpenditureCategoryGroup.MapGetProjectExpenditureCategoryEndpoint();
            ProjectExpenditureCategoryGroup.MapGetProjectExpenditureCategoryListEndpoint();
            ProjectExpenditureCategoryGroup.MapProjectExpenditureCategoryItemUpdationEndpoint();
            ProjectExpenditureCategoryGroup.MapProjectExpenditureCategoryItemActivationEndpoint();
            ProjectExpenditureCategoryGroup.MapProjectExpenditureCategoryItemDeactivationEndpoint();
            ProjectExpenditureCategoryGroup.MapProjectExpenditureCategoryItemDeletionEndpoint();
        }
    }
    public static WebApplicationBuilder RegisterProjectExpenditureCategoryServices(this WebApplicationBuilder builder)
    {
        ArgumentNullException.ThrowIfNull(builder);
        builder.Services.BindDbContext<ProjectExpenditureCategoryDbContext>();
        builder.Services.AddScoped<IDbInitializer, ProjectExpenditureCategoryDbInitializer>();
        builder.Services.AddKeyedScoped<IRepository<ProjectExpenditureCategoryItem>, ProjectExpenditureCategoryRepository<ProjectExpenditureCategoryItem>>("ProjectExpenditureCategories");
        builder.Services.AddKeyedScoped<IReadRepository<ProjectExpenditureCategoryItem>, ProjectExpenditureCategoryRepository<ProjectExpenditureCategoryItem>>("ProjectExpenditureCategories");
        return builder;
    }
    public static WebApplication UseProjectExpenditureCategoryModule(this WebApplication app)
    {
        return app;
    }
}
