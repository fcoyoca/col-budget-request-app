using Carter;
using FSH.Framework.Core.Persistence;
using FSH.Framework.Infrastructure.Persistence;
using budget_request_app.WebApi.BudgetYear.Domain;
using budget_request_app.WebApi.BudgetYear.Features.Create.v1;
using budget_request_app.WebApi.BudgetYear.Persistence;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;

namespace budget_request_app.WebApi.BudgetYear;

public static class BudgetYearModule
{

    public class Endpoints : CarterModule
    {
        public override void AddRoutes(IEndpointRouteBuilder app)
        {
            var BudgetYearGroup = app.MapGroup("budgetYears").WithTags("Budget Years");
            BudgetYearGroup.MapBudgetYearItemCreationEndpoint();
        }
    }
    public static WebApplicationBuilder RegisterBudgetYearServices(this WebApplicationBuilder builder)
    {
        ArgumentNullException.ThrowIfNull(builder);
        builder.Services.BindDbContext<BudgetYearDbContext>();
        builder.Services.AddScoped<IDbInitializer, BudgetYearDbInitializer>();
        builder.Services.AddKeyedScoped<IRepository<BudgetYearItem>, BudgetYearRepository<BudgetYearItem>>("budgetYears");
        builder.Services.AddKeyedScoped<IReadRepository<BudgetYearItem>, BudgetYearRepository<BudgetYearItem>>("budgetYears");
        return builder;
    }
    public static WebApplication UseBudgetYearModule(this WebApplication app)
    {
        return app;
    }
}
