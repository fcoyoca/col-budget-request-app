using budget_request_app.WebApi.FileService.Features.Create.v1;
using Carter;
using FSH.Framework.Core.Persistence;
using FSH.Framework.Infrastructure.Persistence;
using budget_request_app.WebApi.FileService.Domain;
using budget_request_app.WebApi.FileService.Features.Create.v1;
using budget_request_app.WebApi.FileService.Persistence;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;

namespace budget_request_app.WebApi.FileService;
public static class FileServiceModule
{

    public class Endpoints : CarterModule
    {
        public override void AddRoutes(IEndpointRouteBuilder app)
        {
            var FileServiceGroup = app.MapGroup("fileServices").WithTags("File Service");
            FileServiceGroup.MapFileServiceItemCreationEndpoint();
            // FileServiceGroup.MapFileServiceItemCreationEndpoint();
            // FileServiceGroup.MapGetFileServiceEndpoint();
            // FileServiceGroup.MapGetFileServiceListEndpoint();
            // FileServiceGroup.MapFileServiceItemUpdationEndpoint();
            // FileServiceGroup.MapFileServiceItemActivationEndpoint();
            // FileServiceGroup.MapFileServiceItemDeactivationEndpoint();
            // FileServiceGroup.MapFileServiceItemDeletionEndpoint();
        }
    }
    public static WebApplicationBuilder RegisterFileServiceServices(this WebApplicationBuilder builder)
    {
        ArgumentNullException.ThrowIfNull(builder);
        builder.Services.BindDbContext<FileServiceDbContext>();
        builder.Services.AddScoped<IDbInitializer, FileServiceDbInitializer>();
        builder.Services.AddKeyedScoped<IRepository<FileServiceItem>, FileServiceRepository<FileServiceItem>>("fileServices");
        builder.Services.AddKeyedScoped<IReadRepository<FileServiceItem>, FileServiceRepository<FileServiceItem>>("fileServices");
        return builder;
    }
    public static WebApplication UseFileServiceModule(this WebApplication app)
    {
        return app;
    }
}
