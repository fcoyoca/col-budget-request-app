using FSH.Framework.Core.Persistence;
using budget_request_app.WebApi.BudgetYear.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.BudgetYear.Persistence;
internal sealed class BudgetYearDbInitializer(
    ILogger<BudgetYearDbInitializer> logger,
    BudgetYearDbContext context) : IDbInitializer
{
    public async Task MigrateAsync(CancellationToken cancellationToken)
    {
        if ((await context.Database.GetPendingMigrationsAsync(cancellationToken).ConfigureAwait(false)).Any())
        {
            await context.Database.MigrateAsync(cancellationToken).ConfigureAwait(false);
            logger.LogInformation("[{Tenant}] applied database migrations for BudgetYear module", context.TenantInfo!.Identifier);
        }
    }

    public async Task SeedAsync(CancellationToken cancellationToken)
    {
        
    }
}
