using budget_request_app.WebApi.ProjectRequestSubGroup.Domain;
using budget_request_app.WebApi.ProjectRequestSubGroup.Features.Activate.v1;
using budget_request_app.WebApi.ProjectRequestSubGroup.Features.Create.v1;
using budget_request_app.WebApi.ProjectRequestSubGroup.Features.Deactivate.v1;
using budget_request_app.WebApi.ProjectRequestSubGroup.Features.Delete.v1;
using budget_request_app.WebApi.ProjectRequestSubGroup.Features.Get.v1;
using budget_request_app.WebApi.ProjectRequestSubGroup.Features.GetList.v1;
using budget_request_app.WebApi.ProjectRequestSubGroup.Features.Update.v1;
using budget_request_app.WebApi.ProjectRequestSubGroup.Persistence;
using Carter;
using FSH.Framework.Core.Persistence;
using FSH.Framework.Infrastructure.Persistence;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;

namespace budget_request_app.WebApi.ProjectRequestSubGroup;
public static class ProjectRequestSubGroupModule
{
    public class Endpoints : CarterModule
    {
        public override void AddRoutes(IEndpointRouteBuilder app)
        {
            var ProjectRequestSubGroupGroup = app.MapGroup("ProjectRequestSubGroups").WithTags("Project Request Sub Group Values");
            ProjectRequestSubGroupGroup.MapProjectRequestSubGroupItemCreationEndpoint();
            ProjectRequestSubGroupGroup.MapGetProjectRequestSubGroupEndpoint();
            ProjectRequestSubGroupGroup.MapGetProjectRequestSubGroupListEndpoint();
            ProjectRequestSubGroupGroup.MapProjectRequestSubGroupItemUpdationEndpoint();
            ProjectRequestSubGroupGroup.MapProjectRequestSubGroupItemActivationEndpoint();
            ProjectRequestSubGroupGroup.MapProjectRequestSubGroupItemDeactivationEndpoint();
            ProjectRequestSubGroupGroup.MapProjectRequestSubGroupItemDeletionEndpoint();
        }
    }
    public static WebApplicationBuilder RegisterProjectRequestSubGroupServices(this WebApplicationBuilder builder)
    {
        ArgumentNullException.ThrowIfNull(builder);
        builder.Services.BindDbContext<ProjectRequestSubGroupDbContext>();
        builder.Services.AddScoped<IDbInitializer, ProjectRequestSubGroupDbInitializer>();
        builder.Services.AddKeyedScoped<IRepository<ProjectRequestSubGroupItem>, ProjectRequestSubGroupRepository<ProjectRequestSubGroupItem>>("ProjectRequestSubGroups");
        builder.Services.AddKeyedScoped<IReadRepository<ProjectRequestSubGroupItem>, ProjectRequestSubGroupRepository<ProjectRequestSubGroupItem>>("ProjectRequestSubGroups");
        return builder;
    }
    public static WebApplication UseProjectRequestSubGroupModule(this WebApplication app)
    {
        return app;
    }
}
