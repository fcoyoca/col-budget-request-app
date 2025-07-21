using Finbuckle.MultiTenant;
using budget_request_app.WebApi.ProjectRequestSubGroup.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace budget_request_app.WebApi.ProjectRequestSubGroup.Persistence.Configurations;
internal sealed class ProjectRequestSubGroupItemConfiguration : IEntityTypeConfiguration<ProjectRequestSubGroupItem>
{
    public void Configure(EntityTypeBuilder<ProjectRequestSubGroupItem> builder)
    {
        builder.IsMultiTenant();
        builder.HasKey(x => x.Id);
    }
}
