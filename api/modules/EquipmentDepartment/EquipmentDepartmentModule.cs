using budget_request_app.WebApi.EquipmentDepartment.Persistence;
using Carter;
using FSH.Framework.Core.Persistence;
using FSH.Framework.Infrastructure.Persistence;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;

namespace budget_request_app.WebApi.EquipmentDepartment;
public static class EquipmentDepartmentModule
{
    public class Endpoints : CarterModule
    {
        public override void AddRoutes(IEndpointRouteBuilder app)
        {

        }
    }
    public static WebApplicationBuilder RegisterEquipmentDepartmentServices(this WebApplicationBuilder builder)
    {
        ArgumentNullException.ThrowIfNull(builder);
        builder.Services.BindDbContext<EquipmentDepartmentDbContext>();
        builder.Services.AddScoped<IDbInitializer, EquipmentDepartmentDbInitializer>();
        return builder;
    }
    public static WebApplication UseEquipmentDepartmentModule(this WebApplication app)
    {
        return app;
    }
}
