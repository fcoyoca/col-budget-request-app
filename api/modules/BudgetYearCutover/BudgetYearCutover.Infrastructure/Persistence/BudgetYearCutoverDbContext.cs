using BudgetYearCutover.Domain;
using Finbuckle.MultiTenant.Abstractions;
using FSH.Framework.Core.Persistence;
using FSH.Framework.Infrastructure.Persistence;
using FSH.Framework.Infrastructure.Tenant;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace BudgetYearCutover.Infrastructure.Persistence;

public class BudgetYearCutoverDbContext : FshDbContext
{
    public BudgetYearCutoverDbContext(IMultiTenantContextAccessor<FshTenantInfo> multiTenantContextAccessor, DbContextOptions<BudgetYearCutoverDbContext> options, IPublisher publisher, IOptions<DatabaseOptions> settings)
    : base(multiTenantContextAccessor, options, publisher, settings)
    {
        
    }

    public DbSet<CutoverReportCover> CutoverReportCovers => Set<CutoverReportCover>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        ArgumentNullException.ThrowIfNull(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(BudgetYearCutoverDbContext).Assembly);
        modelBuilder.HasDefaultSchema(SchemaNames.BudgetCutover);
        
        modelBuilder.Entity<CutoverReportCover>().HasQueryFilter(p => p.Deleted == null);
    }
}
