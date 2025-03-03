using Carter;
using FSH.Framework.Core.Persistence;
using FSH.Framework.Infrastructure.Persistence;
using budget_request_app.WebApi.LookupCategory.Domain;
using budget_request_app.WebApi.LookupCategory.Features.Create.v1;
using budget_request_app.WebApi.LookupCategory.Features.Delete.v1;
using budget_request_app.WebApi.LookupCategory.Features.Get.v1;
using budget_request_app.WebApi.LookupCategory.Features.GetList.v1;
using budget_request_app.WebApi.LookupCategory.Features.Update.v1;
using budget_request_app.WebApi.LookupCategory.Persistence;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;

namespace budget_request_app.WebApi.LookupCategory;
public static class LookupCategoryModule
{

    public class Endpoints : CarterModule
    {
        public override void AddRoutes(IEndpointRouteBuilder app)
        {
            var lookupCategoryGroup = app.MapGroup("lookupCategories").WithTags("lookupCategories");
            lookupCategoryGroup.MapLookupCategoryItemCreationEndpoint();
            lookupCategoryGroup.MapGetLookupCategoryEndpoint();
            lookupCategoryGroup.MapGetLookupCategoryListEndpoint();
            lookupCategoryGroup.MapLookupCategoryItemUpdationEndpoint();
            lookupCategoryGroup.MapLookupCategoryItemDeletionEndpoint();
        }
    }
    public static WebApplicationBuilder RegisterLookupCategoryServices(this WebApplicationBuilder builder)
    {
        ArgumentNullException.ThrowIfNull(builder);
        builder.Services.BindDbContext<LookupCategoryDbContext>();
        builder.Services.AddScoped<IDbInitializer, LookupCategoryDbInitializer>();
        builder.Services.AddKeyedScoped<IRepository<LookupCategoryItem>, LookupCategoryRepository<LookupCategoryItem>>("lookupCategories");
        builder.Services.AddKeyedScoped<IReadRepository<LookupCategoryItem>, LookupCategoryRepository<LookupCategoryItem>>("lookupCategories");

        return builder;
    }
    public static WebApplication UseLookupCategoryModule(this WebApplication app)
    {
        return app;
    }
}
