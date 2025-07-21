using Finbuckle.MultiTenant.Abstractions;
using FSH.Framework.Core.Persistence;
using FSH.Framework.Infrastructure.Persistence;
using FSH.Framework.Infrastructure.Tenant;
using budget_request_app.WebApi.ProjectRequestGroup.Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace budget_request_app.WebApi.ProjectRequestGroup.Persistence;
public sealed class ProjectRequestGroupDbContext : FshDbContext
{
    public ProjectRequestGroupDbContext(IMultiTenantContextAccessor<FshTenantInfo> multiTenantContextAccessor, DbContextOptions<ProjectRequestGroupDbContext> options, IPublisher publisher, IOptions<DatabaseOptions> settings)
        : base(multiTenantContextAccessor, options, publisher, settings)
    {
    }

    public DbSet<ProjectRequestGroupItem> ProjectRequestGroups { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        ArgumentNullException.ThrowIfNull(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProjectRequestGroupDbContext).Assembly);
        modelBuilder.HasDefaultSchema(SchemaNames.Lookup);
        modelBuilder.Entity<ProjectRequestGroupItem>().HasQueryFilter(p => p.Deleted == null);
    }
}
