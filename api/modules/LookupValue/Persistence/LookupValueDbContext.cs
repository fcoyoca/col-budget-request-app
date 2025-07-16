using budget_request_app.WebApi.LookupCategory.Domain;
using budget_request_app.WebApi.LookupCategory.Persistence;
using budget_request_app.WebApi.LookupValue.Domain;
using Finbuckle.MultiTenant.Abstractions;
using FSH.Framework.Core.Persistence;
using FSH.Framework.Infrastructure.Persistence;
using FSH.Framework.Infrastructure.Tenant;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace budget_request_app.WebApi.LookupValue.Persistence;
public sealed class LookupValueDbContext : FshDbContext
{
    public LookupValueDbContext(IMultiTenantContextAccessor<FshTenantInfo> multiTenantContextAccessor, DbContextOptions<LookupValueDbContext> options, IPublisher publisher, IOptions<DatabaseOptions> settings)
        : base(multiTenantContextAccessor, options, publisher, settings)
    {
    }

    public DbSet<LookupValueItem> LookupValues { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        ArgumentNullException.ThrowIfNull(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(LookupValueDbContext).Assembly);
        modelBuilder.HasDefaultSchema(SchemaNames.Lookup);
        modelBuilder.Entity<LookupValueItem>().HasQueryFilter(p => p.Deleted == null);
        modelBuilder.Entity<LookupValueItem>().HasData(LookupValueSeeder.GetSeedData());
    }
}
