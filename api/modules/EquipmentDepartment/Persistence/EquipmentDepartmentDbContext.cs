using Finbuckle.MultiTenant.Abstractions;
using FSH.Framework.Core.Persistence;
using FSH.Framework.Infrastructure.Persistence;
using FSH.Framework.Infrastructure.Tenant;
using budget_request_app.WebApi.EquipmentDepartment.Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace budget_request_app.WebApi.EquipmentDepartment.Persistence;
public sealed class EquipmentDepartmentDbContext : FshDbContext
{
    public EquipmentDepartmentDbContext(IMultiTenantContextAccessor<FshTenantInfo> multiTenantContextAccessor, DbContextOptions<EquipmentDepartmentDbContext> options, IPublisher publisher, IOptions<DatabaseOptions> settings)
        : base(multiTenantContextAccessor, options, publisher, settings)
    {
    }

    public DbSet<EquipmentDepartmentItem> EquipmentDepartments { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        ArgumentNullException.ThrowIfNull(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(EquipmentDepartmentDbContext).Assembly);
        modelBuilder.HasDefaultSchema(SchemaNames.Lookup);
        modelBuilder.Entity<EquipmentDepartmentItem>().HasQueryFilter(p => p.Deleted == null);
    }
}
