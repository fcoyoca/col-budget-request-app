using Finbuckle.MultiTenant.Abstractions;
using FSH.Framework.Core.Persistence;
using FSH.Framework.Infrastructure.Persistence;
using FSH.Framework.Infrastructure.Tenant;
using budget_request_app.WebApi.ProjectBudgetIntroSectionOutlineItem.Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace budget_request_app.WebApi.ProjectBudgetIntroSectionOutlineItem.Persistence;
public sealed class ProjectBudgetIntroSectionOutlineItemDbContext : FshDbContext
{
    public ProjectBudgetIntroSectionOutlineItemDbContext(IMultiTenantContextAccessor<FshTenantInfo> multiTenantContextAccessor, DbContextOptions<ProjectBudgetIntroSectionOutlineItemDbContext> options, IPublisher publisher, IOptions<DatabaseOptions> settings)
        : base(multiTenantContextAccessor, options, publisher, settings)
    {
    }

    public DbSet<ProjectBudgetIntroSectionOutlineItemItem> ProjectBudgetIntroSectionOutlineItems { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        ArgumentNullException.ThrowIfNull(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProjectBudgetIntroSectionOutlineItemDbContext).Assembly);
        modelBuilder.HasDefaultSchema(SchemaNames.Lookup);
        modelBuilder.Entity<ProjectBudgetIntroSectionOutlineItemItem>().HasQueryFilter(p => p.Deleted == null);
    }
}
