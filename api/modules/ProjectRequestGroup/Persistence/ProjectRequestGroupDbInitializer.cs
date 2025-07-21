using FSH.Framework.Core.Persistence;
using budget_request_app.WebApi.ProjectRequestGroup.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.ProjectRequestGroup.Persistence;
internal sealed class ProjectRequestGroupDbInitializer(
    ILogger<ProjectRequestGroupDbInitializer> logger,
    ProjectRequestGroupDbContext context) : IDbInitializer
{
    public async Task MigrateAsync(CancellationToken cancellationToken)
    {
        if ((await context.Database.GetPendingMigrationsAsync(cancellationToken).ConfigureAwait(false)).Any())
        {
            await context.Database.MigrateAsync(cancellationToken).ConfigureAwait(false);
            logger.LogInformation("[{Tenant}] applied database migrations for ProjectRequestGroup module", context.TenantInfo!.Identifier);
        }
    }

    public async Task SeedAsync(CancellationToken cancellationToken)
    {
        
    }
}
