using BudgetYearCutover.Domain;
using BudgetYearCutover.Infrastructure.Endpoints.v1.ReportCovers;
using BudgetYearCutover.Infrastructure.Persistence;
using Carter;
using FSH.Framework.Core.Persistence;
using FSH.Framework.Infrastructure.Persistence;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;

namespace BudgetYearCutover.Infrastructure;

public static class BudgetYearCutoverModule
{
    public class Endpoints : CarterModule
    {
        public Endpoints() { }
        public override void AddRoutes(IEndpointRouteBuilder app)
        {
            var group = app.MapGroup("budgetYearCutover").WithTags("BudgetYear Cutover");

            group.MapReportCoversEndpoint();
        }
    }

    public static WebApplicationBuilder RegisterBudgetYearCutoverServices(this WebApplicationBuilder builder)
    {
        ArgumentNullException.ThrowIfNull(builder);
        builder.Services.BindDbContext<BudgetYearCutoverDbContext>();
        builder.Services.AddScoped<IDbInitializer, BudgetYearCutoverDbInitializer>();

        builder.Services.AddKeyedScoped<IRepository<CutoverReportCover>, BudgetyearCutoverRepository<CutoverReportCover>>("budgetYearCutover");
        builder.Services.AddKeyedScoped<IReadRepository<CutoverReportCover>, BudgetyearCutoverRepository<CutoverReportCover>>("budgetYearCutover");
        return builder;
    }

    public static WebApplication UseBudgetYearCutoverModule(this WebApplication app)
    {
        return app;
    }
}
