using Finbuckle.MultiTenant;
using budget_request_app.WebApi.ProjectRequestStatus.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace budget_request_app.WebApi.ProjectRequestStatus.Persistence.Configurations;
internal sealed class ProjectRequestStatusItemConfiguration : IEntityTypeConfiguration<ProjectRequestStatusItem>
{
    public void Configure(EntityTypeBuilder<ProjectRequestStatusItem> builder)
    {
        builder.IsMultiTenant();
        builder.HasKey(x => x.Id);
    }
}
