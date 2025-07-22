using budget_request_app.WebApi.ProjectRequestStatus.Domain;
using budget_request_app.WebApi.ProjectRequestStatus.Features.Activate.v1;
using budget_request_app.WebApi.ProjectRequestStatus.Features.Create.v1;
using budget_request_app.WebApi.ProjectRequestStatus.Features.Deactivate.v1;
using budget_request_app.WebApi.ProjectRequestStatus.Features.Delete.v1;
using budget_request_app.WebApi.ProjectRequestStatus.Features.Get.v1;
using budget_request_app.WebApi.ProjectRequestStatus.Features.GetList.v1;
using budget_request_app.WebApi.ProjectRequestStatus.Features.Update.v1;
using budget_request_app.WebApi.ProjectRequestStatus.Persistence;
using Carter;
using FSH.Framework.Core.Persistence;
using FSH.Framework.Infrastructure.Persistence;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;

namespace budget_request_app.WebApi.ProjectRequestStatus;
public static class ProjectRequestStatusModule
{
    public class Endpoints : CarterModule
    {
        public override void AddRoutes(IEndpointRouteBuilder app)
        {
            var ProjectRequestStatusGroup = app.MapGroup("ProjectRequestStatuses").WithTags("Project Request Status Values");
            ProjectRequestStatusGroup.MapProjectRequestStatusItemCreationEndpoint();
            ProjectRequestStatusGroup.MapGetProjectRequestStatusEndpoint();
            ProjectRequestStatusGroup.MapGetProjectRequestStatusListEndpoint();
            ProjectRequestStatusGroup.MapProjectRequestStatusItemUpdationEndpoint();
            ProjectRequestStatusGroup.MapProjectRequestStatusItemActivationEndpoint();
            ProjectRequestStatusGroup.MapProjectRequestStatusItemDeactivationEndpoint();
            ProjectRequestStatusGroup.MapProjectRequestStatusItemDeletionEndpoint();
        }
    }
    public static WebApplicationBuilder RegisterProjectRequestStatusServices(this WebApplicationBuilder builder)
    {
        ArgumentNullException.ThrowIfNull(builder);
        builder.Services.BindDbContext<ProjectRequestStatusDbContext>();
        builder.Services.AddScoped<IDbInitializer, ProjectRequestStatusDbInitializer>();
        builder.Services.AddKeyedScoped<IRepository<ProjectRequestStatusItem>, ProjectRequestStatusRepository<ProjectRequestStatusItem>>("ProjectRequestStatuses");
        builder.Services.AddKeyedScoped<IReadRepository<ProjectRequestStatusItem>, ProjectRequestStatusRepository<ProjectRequestStatusItem>>("ProjectRequestStatuses");
        return builder;
    }
    public static WebApplication UseProjectRequestStatusModule(this WebApplication app)
    {
        return app;
    }
}
