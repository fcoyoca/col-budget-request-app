using FSH.Framework.Core.Persistence;
using budget_request_app.WebApi.FileService.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.FileService.Persistence;
internal sealed class FileServiceDbInitializer(
    ILogger<FileServiceDbInitializer> logger,
    FileServiceDbContext context) : IDbInitializer
{
    public async Task MigrateAsync(CancellationToken cancellationToken)
    {
        if ((await context.Database.GetPendingMigrationsAsync(cancellationToken).ConfigureAwait(false)).Any())
        {
            await context.Database.MigrateAsync(cancellationToken).ConfigureAwait(false);
            logger.LogInformation("[{Tenant}] applied database migrations for FileService module", context.TenantInfo!.Identifier);
        }
    }

    public async Task SeedAsync(CancellationToken cancellationToken)
    {
        
    }
}
