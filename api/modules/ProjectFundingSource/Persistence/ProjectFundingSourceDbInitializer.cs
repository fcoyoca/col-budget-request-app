using FSH.Framework.Core.Persistence;
using budget_request_app.WebApi.ProjectFundingSource.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.ProjectFundingSource.Persistence;
internal sealed class ProjectFundingSourceDbInitializer(
    ILogger<ProjectFundingSourceDbInitializer> logger,
    ProjectFundingSourceDbContext context) : IDbInitializer
{
    public async Task MigrateAsync(CancellationToken cancellationToken)
    {
        if ((await context.Database.GetPendingMigrationsAsync(cancellationToken).ConfigureAwait(false)).Any())
        {
            await context.Database.MigrateAsync(cancellationToken).ConfigureAwait(false);
            logger.LogInformation("[{Tenant}] applied database migrations for ProjectFundingSource module", context.TenantInfo!.Identifier);
        }
    }

    public async Task SeedAsync(CancellationToken cancellationToken)
    {
        
    }
}
