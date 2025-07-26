using budget_request_app.WebApi.LookupValue.Domain;
using budget_request_app.WebApi.LookupValue.Features.EquipmentDepartments.Activate.v1;
using budget_request_app.WebApi.LookupValue.Features.EquipmentDepartments.Create.v1;
using budget_request_app.WebApi.LookupValue.Features.EquipmentDepartments.Deactivate.v1;
using budget_request_app.WebApi.LookupValue.Features.EquipmentDepartments.Delete.v1;
using budget_request_app.WebApi.LookupValue.Features.EquipmentDepartments.Get.v1;
using budget_request_app.WebApi.LookupValue.Features.EquipmentDepartments.GetList.v1;
using budget_request_app.WebApi.LookupValue.Features.EquipmentDepartments.Update.v1;
using budget_request_app.WebApi.LookupValue.Features.LookupValues.Activate.v1;
using budget_request_app.WebApi.LookupValue.Features.LookupValues.Create.v1;
using budget_request_app.WebApi.LookupValue.Features.LookupValues.Deactivate.v1;
using budget_request_app.WebApi.LookupValue.Features.LookupValues.Delete.v1;
using budget_request_app.WebApi.LookupValue.Features.LookupValues.Get.v1;
using budget_request_app.WebApi.LookupValue.Features.LookupValues.GetList.v1;
using budget_request_app.WebApi.LookupValue.Features.LookupValues.Update.v1;
using budget_request_app.WebApi.LookupValue.Persistence;
using Carter;
using FSH.Framework.Core.Persistence;
using FSH.Framework.Infrastructure.Persistence;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;

namespace budget_request_app.WebApi.LookupValue;
public static class LookupValueModule
{

    public class Endpoints : CarterModule
    {
        public override void AddRoutes(IEndpointRouteBuilder app)
        {
            var LookupValueGroup = app.MapGroup("lookupValues").WithTags("Lookup Values");
            LookupValueGroup.MapLookupValueItemCreationEndpoint();
            LookupValueGroup.MapGetLookupValueEndpoint();
            LookupValueGroup.MapGetLookupValueListEndpoint();
            LookupValueGroup.MapLookupValueItemUpdationEndpoint();
            LookupValueGroup.MapLookupValueItemActivationEndpoint();
            LookupValueGroup.MapLookupValueItemDeactivationEndpoint();
            LookupValueGroup.MapLookupValueItemDeletionEndpoint();
            LookupValueGroup.AllowAnonymous();

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
    public static WebApplicationBuilder RegisterLookupValueServices(this WebApplicationBuilder builder)
    {
        ArgumentNullException.ThrowIfNull(builder);
        builder.Services.BindDbContext<LookupValueDbContext>();
        builder.Services.AddScoped<IDbInitializer, LookupValueDbInitializer>();
        builder.Services.AddKeyedScoped<IRepository<LookupValueItem>, LookupValueRepository<LookupValueItem>>("lookupValues");
        builder.Services.AddKeyedScoped<IReadRepository<LookupValueItem>, LookupValueRepository<LookupValueItem>>("lookupValues");

        builder.Services.AddKeyedScoped<IRepository<EquipmentDepartmentItem>, LookupValueRepository<EquipmentDepartmentItem>>("EquipmentDepartments");
        builder.Services.AddKeyedScoped<IReadRepository<EquipmentDepartmentItem>, LookupValueRepository<EquipmentDepartmentItem>>("EquipmentDepartments");

        return builder;
    }
    public static WebApplication UseLookupValueModule(this WebApplication app)
    {
        return app;
    }
}
