using Finbuckle.MultiTenant.Abstractions;
using FSH.Framework.Core.Persistence;
using FSH.Framework.Infrastructure.Persistence;
using FSH.Framework.Infrastructure.Tenant;
using budget_request_app.WebApi.BudgetYear.Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace budget_request_app.WebApi.BudgetYear.Persistence;
public sealed class BudgetYearDbContext : FshDbContext
{
    public BudgetYearDbContext(IMultiTenantContextAccessor<FshTenantInfo> multiTenantContextAccessor, DbContextOptions<BudgetYearDbContext> options, IPublisher publisher, IOptions<DatabaseOptions> settings)
        : base(multiTenantContextAccessor, options, publisher, settings)
    {
    }

    public DbSet<BudgetYearItem> BudgetYears { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        ArgumentNullException.ThrowIfNull(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(BudgetYearDbContext).Assembly);
        modelBuilder.HasDefaultSchema(SchemaNames.Lookup);
        modelBuilder.Entity<BudgetYearItem>().HasQueryFilter(p => p.Deleted == null);
    }
}
