using Finbuckle.MultiTenant;
using budget_request_app.WebApi.ProjectRequestGroup.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace budget_request_app.WebApi.ProjectRequestGroup.Persistence.Configurations;
internal sealed class ProjectRequestGroupItemConfiguration : IEntityTypeConfiguration<ProjectRequestGroupItem>
{
    public void Configure(EntityTypeBuilder<ProjectRequestGroupItem> builder)
    {
        builder.IsMultiTenant();
        builder.HasKey(x => x.Id);
    }
}
