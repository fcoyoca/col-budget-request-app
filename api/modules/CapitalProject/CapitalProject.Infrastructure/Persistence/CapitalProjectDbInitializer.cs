﻿using FSH.Framework.Core.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.CapitalProject.Infrastructure.Persistence;
internal sealed class CapitalProjectDbInitializer(
    ILogger<CapitalProjectDbInitializer> logger,
    CapitalProjectDbContext context) : IDbInitializer
{
    public async Task MigrateAsync(CancellationToken cancellationToken)
    {
        if ((await context.Database.GetPendingMigrationsAsync(cancellationToken)).Any())
        {
            await context.Database.MigrateAsync(cancellationToken).ConfigureAwait(false);
            logger.LogInformation("[{Tenant}] applied database migrations for CapitalProject module", context.TenantInfo!.Identifier);
        }
    }

    public async Task SeedAsync(CancellationToken cancellationToken)
    {
        //const string Name = "Keychron V6 QMK Custom Wired Mechanical Keyboard";
        //const string Description = "A full-size layout QMK/VIA custom mechanical keyboard";
        //const decimal Price = 79;
        //Guid? BrandId = null;
        //if (await context.Products.FirstOrDefaultAsync(t => t.Name == Name, cancellationToken).ConfigureAwait(false) is null)
        //{
        //    var product = Product.Create(Name, Description, Price, BrandId);
        //    await context.Products.AddAsync(product, cancellationToken);
        //    await context.SaveChangesAsync(cancellationToken).ConfigureAwait(false);
        //    logger.LogInformation("[{Tenant}] seeding default CapitalProject data", context.TenantInfo!.Identifier);
        //}
    }
}
