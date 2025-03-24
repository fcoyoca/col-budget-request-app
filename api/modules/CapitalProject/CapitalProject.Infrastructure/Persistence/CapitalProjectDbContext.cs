using Finbuckle.MultiTenant.Abstractions;
using FSH.Framework.Core.Persistence;
using FSH.Framework.Infrastructure.Persistence;
using FSH.Framework.Infrastructure.Tenant;
using budget_request_app.WebApi.CapitalProject.Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace budget_request_app.WebApi.CapitalProject.Infrastructure.Persistence;

public sealed class CapitalProjectDbContext : FshDbContext
{
    public CapitalProjectDbContext(IMultiTenantContextAccessor<FshTenantInfo> multiTenantContextAccessor, DbContextOptions<CapitalProjectDbContext> options, IPublisher publisher, IOptions<DatabaseOptions> settings)
        : base(multiTenantContextAccessor, options, publisher, settings)
    {
    }

    public DbSet<CapitalProjectItem> CapitalProjects { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        ArgumentNullException.ThrowIfNull(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(CapitalProjectDbContext).Assembly);
        modelBuilder.HasDefaultSchema(SchemaNames.CapitalProject);
        
        //soft deletes
        modelBuilder.Entity<CapitalProjectItem>().HasQueryFilter(p => p.Deleted == null);
    }
}
