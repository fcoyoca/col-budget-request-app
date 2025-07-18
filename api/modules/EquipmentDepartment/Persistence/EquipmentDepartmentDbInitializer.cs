using FSH.Framework.Core.Persistence;
using budget_request_app.WebApi.EquipmentDepartment.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.EquipmentDepartment.Persistence;
internal sealed class EquipmentDepartmentDbInitializer(
    ILogger<EquipmentDepartmentDbInitializer> logger,
    EquipmentDepartmentDbContext context) : IDbInitializer
{
    public async Task MigrateAsync(CancellationToken cancellationToken)
    {
        if ((await context.Database.GetPendingMigrationsAsync(cancellationToken).ConfigureAwait(false)).Any())
        {
            await context.Database.MigrateAsync(cancellationToken).ConfigureAwait(false);
            logger.LogInformation("[{Tenant}] applied database migrations for EquipmentDepartment module", context.TenantInfo!.Identifier);
        }
    }

    public async Task SeedAsync(CancellationToken cancellationToken)
    {
        
    }
}
