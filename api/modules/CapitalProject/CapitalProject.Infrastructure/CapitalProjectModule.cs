using Carter;
using FSH.Framework.Core.Persistence;
using FSH.Framework.Infrastructure.Persistence;
using budget_request_app.WebApi.CapitalProject.Domain;
using budget_request_app.WebApi.CapitalProject.Infrastructure.Endpoints.v1.CapitalProjects;
//using budget_request_app.WebApi.CapitalProject.Infrastructure.Endpoints.v1.CapitalProjects;
using budget_request_app.WebApi.CapitalProject.Infrastructure.Persistence;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;

namespace budget_request_app.WebApi.CapitalProject.Infrastructure;
public static class CapitalProjectModule
{
    public class Endpoints : CarterModule
    {
        public Endpoints() { }
        public override void AddRoutes(IEndpointRouteBuilder app)
        {
            var capitalProjectGroup = app.MapGroup("capitalProjects").WithTags("Capital Projects");
            capitalProjectGroup.MapGetCapitalProjectEndpoint();
        }
    }
    public static WebApplicationBuilder RegisterCapitalProjectServices(this WebApplicationBuilder builder)
    {
        ArgumentNullException.ThrowIfNull(builder);
        builder.Services.BindDbContext<CapitalProjectDbContext>();
        builder.Services.AddScoped<IDbInitializer, CapitalProjectDbInitializer>();
        
        builder.Services.AddKeyedScoped<IRepository<CapitalProjectItem>, CapitalProjectRepository<CapitalProjectItem>>("capitalProjects");
        builder.Services.AddKeyedScoped<IReadRepository<CapitalProjectItem>, CapitalProjectRepository<CapitalProjectItem>>("capitalProjects");
        
        return builder;
    }
    public static WebApplication UseCapitalProjectModule(this WebApplication app)
    {
        return app;
    }
}
