using budget_request_app.WebApi.ProjectBudgetIntroSectionOutlineItem.Domain;
using budget_request_app.WebApi.ProjectBudgetIntroSectionOutlineItem.Features.Activate.v1;
using budget_request_app.WebApi.ProjectBudgetIntroSectionOutlineItem.Features.Create.v1;
using budget_request_app.WebApi.ProjectBudgetIntroSectionOutlineItem.Features.Deactivate.v1;
using budget_request_app.WebApi.ProjectBudgetIntroSectionOutlineItem.Features.Delete.v1;
using budget_request_app.WebApi.ProjectBudgetIntroSectionOutlineItem.Features.Get.v1;
using budget_request_app.WebApi.ProjectBudgetIntroSectionOutlineItem.Features.GetList.v1;
using budget_request_app.WebApi.ProjectBudgetIntroSectionOutlineItem.Features.Update.v1;
using budget_request_app.WebApi.ProjectBudgetIntroSectionOutlineItem.Persistence;
using Carter;
using FSH.Framework.Core.Persistence;
using FSH.Framework.Infrastructure.Persistence;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;

namespace budget_request_app.WebApi.ProjectBudgetIntroSectionOutlineItem;
public static class ProjectBudgetIntroSectionOutlineItemModule
{
    public class Endpoints : CarterModule
    {
        public override void AddRoutes(IEndpointRouteBuilder app)
        {
            var ProjectBudgetIntroSectionOutlineItemGroup = app.MapGroup("ProjectBudgetIntroSectionOutlineItems").WithTags("Project Budget Intro Section Outline Item Values");
            ProjectBudgetIntroSectionOutlineItemGroup.MapProjectBudgetIntroSectionOutlineItemItemCreationEndpoint();
            ProjectBudgetIntroSectionOutlineItemGroup.MapGetProjectBudgetIntroSectionOutlineItemEndpoint();
            ProjectBudgetIntroSectionOutlineItemGroup.MapGetProjectBudgetIntroSectionOutlineItemListEndpoint();
            ProjectBudgetIntroSectionOutlineItemGroup.MapProjectBudgetIntroSectionOutlineItemItemUpdationEndpoint();
            ProjectBudgetIntroSectionOutlineItemGroup.MapProjectBudgetIntroSectionOutlineItemItemActivationEndpoint();
            ProjectBudgetIntroSectionOutlineItemGroup.MapProjectBudgetIntroSectionOutlineItemItemDeactivationEndpoint();
            ProjectBudgetIntroSectionOutlineItemGroup.MapProjectBudgetIntroSectionOutlineItemItemDeletionEndpoint();
        }
    }
    public static WebApplicationBuilder RegisterProjectBudgetIntroSectionOutlineItemServices(this WebApplicationBuilder builder)
    {
        ArgumentNullException.ThrowIfNull(builder);
        builder.Services.BindDbContext<ProjectBudgetIntroSectionOutlineItemDbContext>();
        builder.Services.AddScoped<IDbInitializer, ProjectBudgetIntroSectionOutlineItemDbInitializer>();
        builder.Services.AddKeyedScoped<IRepository<ProjectBudgetIntroSectionOutlineItemItem>, ProjectBudgetIntroSectionOutlineItemRepository<ProjectBudgetIntroSectionOutlineItemItem>>("ProjectBudgetIntroSectionOutlineItems");
        builder.Services.AddKeyedScoped<IReadRepository<ProjectBudgetIntroSectionOutlineItemItem>, ProjectBudgetIntroSectionOutlineItemRepository<ProjectBudgetIntroSectionOutlineItemItem>>("ProjectBudgetIntroSectionOutlineItems");
        return builder;
    }
    public static WebApplication UseProjectBudgetIntroSectionOutlineItemModule(this WebApplication app)
    {
        return app;
    }
}
