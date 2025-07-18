using Carter;
using FSH.Framework.Core.Persistence;
using FSH.Framework.Infrastructure.Persistence;
using budget_request_app.WebApi.EquipmentDepartment.Domain;
using budget_request_app.WebApi.EquipmentDepartment.Features.Create.v1;
using budget_request_app.WebApi.EquipmentDepartment.Features.Delete.v1;
using budget_request_app.WebApi.EquipmentDepartment.Features.Get.v1;
using budget_request_app.WebApi.EquipmentDepartment.Features.GetList.v1;
using budget_request_app.WebApi.EquipmentDepartment.Features.Update.v1;
using budget_request_app.WebApi.EquipmentDepartment.Features.Activate.v1;
using budget_request_app.WebApi.EquipmentDepartment.Features.Deactivate.v1;
using budget_request_app.WebApi.EquipmentDepartment.Persistence;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;

namespace budget_request_app.WebApi.EquipmentDepartment;
public static class EquipmentDepartmentModule
{
    public class Endpoints : CarterModule
    {
        public override void AddRoutes(IEndpointRouteBuilder app)
        {
            var EquipmentDepartmentGroup = app.MapGroup("EquipmentDepartments").WithTags("Equipment Department Values");
            EquipmentDepartmentGroup.MapEquipmentDepartmentItemCreationEndpoint();
            EquipmentDepartmentGroup.MapGetEquipmentDepartmentEndpoint();
            EquipmentDepartmentGroup.MapGetEquipmentDepartmentListEndpoint();
            EquipmentDepartmentGroup.MapEquipmentDepartmentItemUpdationEndpoint();
            EquipmentDepartmentGroup.MapEquipmentDepartmentItemActivationEndpoint();
            EquipmentDepartmentGroup.MapEquipmentDepartmentItemDeactivationEndpoint();
            EquipmentDepartmentGroup.MapEquipmentDepartmentItemDeletionEndpoint();
        }
    }
    public static WebApplicationBuilder RegisterEquipmentDepartmentServices(this WebApplicationBuilder builder)
    {
        ArgumentNullException.ThrowIfNull(builder);
        builder.Services.BindDbContext<EquipmentDepartmentDbContext>();
        builder.Services.AddScoped<IDbInitializer, EquipmentDepartmentDbInitializer>();
        builder.Services.AddKeyedScoped<IRepository<EquipmentDepartmentItem>, EquipmentDepartmentRepository<EquipmentDepartmentItem>>("EquipmentDepartments");
        builder.Services.AddKeyedScoped<IReadRepository<EquipmentDepartmentItem>, EquipmentDepartmentRepository<EquipmentDepartmentItem>>("EquipmentDepartments");
        return builder;
    }
    public static WebApplication UseEquipmentDepartmentModule(this WebApplication app)
    {
        return app;
    }
}
