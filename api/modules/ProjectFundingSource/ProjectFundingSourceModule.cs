using Carter;
using FSH.Framework.Core.Persistence;
using FSH.Framework.Infrastructure.Persistence;
using budget_request_app.WebApi.ProjectFundingSource.Domain;
using budget_request_app.WebApi.ProjectFundingSource.Features.Create.v1;
using budget_request_app.WebApi.ProjectFundingSource.Features.Delete.v1;
using budget_request_app.WebApi.ProjectFundingSource.Features.Get.v1;
using budget_request_app.WebApi.ProjectFundingSource.Features.GetList.v1;
using budget_request_app.WebApi.ProjectFundingSource.Features.Update.v1;
using budget_request_app.WebApi.ProjectFundingSource.Features.Activate.v1;
using budget_request_app.WebApi.ProjectFundingSource.Features.Deactivate.v1;
using budget_request_app.WebApi.ProjectFundingSource.Persistence;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;

namespace budget_request_app.WebApi.ProjectFundingSource;
public static class ProjectFundingSourceModule
{

    public class Endpoints : CarterModule
    {
        public override void AddRoutes(IEndpointRouteBuilder app)
        {
            var ProjectFundingSourceGroup = app.MapGroup("ProjectFundingSources").WithTags("Project Funding Source Values");
            ProjectFundingSourceGroup.MapProjectFundingSourceItemCreationEndpoint();
            ProjectFundingSourceGroup.MapGetProjectFundingSourceEndpoint();
            ProjectFundingSourceGroup.MapGetProjectFundingSourceListEndpoint();
            ProjectFundingSourceGroup.MapProjectFundingSourceItemUpdationEndpoint();
            ProjectFundingSourceGroup.MapProjectFundingSourceItemActivationEndpoint();
            ProjectFundingSourceGroup.MapProjectFundingSourceItemDeactivationEndpoint();
            ProjectFundingSourceGroup.MapProjectFundingSourceItemDeletionEndpoint();
        }
    }
    public static WebApplicationBuilder RegisterProjectFundingSourceServices(this WebApplicationBuilder builder)
    {
        ArgumentNullException.ThrowIfNull(builder);
        builder.Services.BindDbContext<ProjectFundingSourceDbContext>();
        builder.Services.AddScoped<IDbInitializer, ProjectFundingSourceDbInitializer>();
        builder.Services.AddKeyedScoped<IRepository<ProjectFundingSourceItem>, ProjectFundingSourceRepository<ProjectFundingSourceItem>>("ProjectFundingSources");
        builder.Services.AddKeyedScoped<IReadRepository<ProjectFundingSourceItem>, ProjectFundingSourceRepository<ProjectFundingSourceItem>>("ProjectFundingSources");
        return builder;
    }
    public static WebApplication UseProjectFundingSourceModule(this WebApplication app)
    {
        return app;
    }
}
