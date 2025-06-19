using Finbuckle.MultiTenant.Abstractions;
using FSH.Framework.Core.Persistence;
using FSH.Framework.Infrastructure.Persistence;
using FSH.Framework.Infrastructure.Tenant;
using budget_request_app.WebApi.CapitalEquipment.Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace budget_request_app.WebApi.CapitalEquipment.Infrastructure.Persistence;

public sealed class CapitalEquipmentDbContext : FshDbContext
{
    public CapitalEquipmentDbContext(IMultiTenantContextAccessor<FshTenantInfo> multiTenantContextAccessor, DbContextOptions<CapitalEquipmentDbContext> options, IPublisher publisher, IOptions<DatabaseOptions> settings)
        : base(multiTenantContextAccessor, options, publisher, settings)
    {
    }

    public DbSet<CapitalEquipmentItem> CapitalEquipments { get; set; } = null!;
    public DbSet<FundingItem> FundingItem { get; set; } = null!;
    //public DbSet<PastFunding> PastFunding { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        ArgumentNullException.ThrowIfNull(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(CapitalEquipmentDbContext).Assembly);
        modelBuilder.HasDefaultSchema(SchemaNames.CapitalEquipment);
        
        //soft deletes
        modelBuilder.Entity<CapitalEquipmentItem>().HasQueryFilter(p => p.Deleted == null);
        modelBuilder.Entity<FundingItem>().HasQueryFilter(p => p.Deleted == null);
        //modelBuilder.Entity<PastFunding>().HasQueryFilter(p => p.Deleted == null);
    }
}
