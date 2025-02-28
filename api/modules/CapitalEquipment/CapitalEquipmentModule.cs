using Carter;
using FSH.WebApi.Modules.Catalog.Features.Products.ProductCreation.v1;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace FSH.WebApi.Modules.CapitalEquipment;

public static class CapitalEquipmentModule
{
    public class Endpoints : CarterModule
    {
        public Endpoints() : base("capitalEquipment") { }
        public override void AddRoutes(IEndpointRouteBuilder app)
        {
            // var productGroup = app.MapGroup("products").WithTags("products");
            // productGroup.MapProductCreationEndpoint();
            //
            // var testGroup = app.MapGroup("test").WithTags("test");
            // testGroup.MapGet("/test", () => "hi");
        }
    }
    public static WebApplicationBuilder RegisterCatalogServices(this WebApplicationBuilder builder)
    {
        ArgumentNullException.ThrowIfNull(builder);
        return builder;
    }
    public static WebApplication UseCatalogModule(this WebApplication app)
    {
        return app;
    }
}
