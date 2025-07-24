using budget_request_app.WebApi.ProjectRequestGroup.Domain;
using budget_request_app.WebApi.ProjectRequestGroup.Features.Activate.v1;
using budget_request_app.WebApi.ProjectRequestGroup.Features.Create.v1;
using budget_request_app.WebApi.ProjectRequestGroup.Features.Deactivate.v1;
using budget_request_app.WebApi.ProjectRequestGroup.Features.Delete.v1;
using budget_request_app.WebApi.ProjectRequestGroup.Features.Get.v1;
using budget_request_app.WebApi.ProjectRequestGroup.Features.GetList.v1;
using budget_request_app.WebApi.ProjectRequestGroup.Features.Update.v1;
using budget_request_app.WebApi.ProjectRequestGroup.Persistence;
using Carter;
using FSH.Framework.Core.Persistence;
using FSH.Framework.Infrastructure.Persistence;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;

namespace budget_request_app.WebApi.ProjectRequestGroup;
public static class ProjectRequestGroupModule
{
    public class Endpoints : CarterModule
    {
        public override void AddRoutes(IEndpointRouteBuilder app)
        {
            var ProjectSubGroupGroup = app.MapGroup("ProjectRequestGroups").WithTags("Project Request Group Values");
            ProjectSubGroupGroup.MapProjectRequestGroupItemCreationEndpoint();
            ProjectSubGroupGroup.MapGetProjectRequestGroupEndpoint();
            ProjectSubGroupGroup.MapGetProjectRequestGroupListEndpoint();
            ProjectSubGroupGroup.MapProjectRequestGroupItemUpdationEndpoint();
            ProjectSubGroupGroup.MapProjectRequestGroupItemActivationEndpoint();
            ProjectSubGroupGroup.MapProjectRequestGroupItemDeactivationEndpoint();
            ProjectSubGroupGroup.MapProjectRequestGroupItemDeletionEndpoint();
        }
    }
    public static WebApplicationBuilder RegisterProjectRequestGroupServices(this WebApplicationBuilder builder)
    {
        ArgumentNullException.ThrowIfNull(builder);
        builder.Services.BindDbContext<ProjectRequestGroupDbContext>();
        builder.Services.AddScoped<IDbInitializer, ProjectRequestGroupDbInitializer>();
        builder.Services.AddKeyedScoped<IRepository<ProjectRequestGroupItem>, ProjectRequestGroupRepository<ProjectRequestGroupItem>>("ProjectRequestGroups");
        builder.Services.AddKeyedScoped<IReadRepository<ProjectRequestGroupItem>, ProjectRequestGroupRepository<ProjectRequestGroupItem>>("ProjectRequestGroups");
        return builder;
    }
    public static WebApplication UseProjectRequestGroupModule(this WebApplication app)
    {
        return app;
    }
}
