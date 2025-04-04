using Finbuckle.MultiTenant.Abstractions;
using FSH.Framework.Core.Persistence;
using FSH.Framework.Infrastructure.Persistence;
using FSH.Framework.Infrastructure.Tenant;
using budget_request_app.WebApi.FileService.Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace budget_request_app.WebApi.FileService.Persistence;
public sealed class FileServiceDbContext : FshDbContext
{
    public FileServiceDbContext(IMultiTenantContextAccessor<FshTenantInfo> multiTenantContextAccessor, DbContextOptions<FileServiceDbContext> options, IPublisher publisher, IOptions<DatabaseOptions> settings)
        : base(multiTenantContextAccessor, options, publisher, settings)
    {
    }

    public DbSet<FileServiceItem> FileServiceItem { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        ArgumentNullException.ThrowIfNull(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(FileServiceDbContext).Assembly);
        modelBuilder.HasDefaultSchema(SchemaNames.FileService);
        modelBuilder.Entity<FileServiceItem>().HasQueryFilter(p => p.Deleted == null);
    }
}
