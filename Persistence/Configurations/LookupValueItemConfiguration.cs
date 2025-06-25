using Finbuckle.MultiTenant;
using budget_request_app.WebApi.ProjectFundingSource.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace budget_request_app.WebApi.ProjectFundingSource.Persistence.Configurations;
internal sealed class ProjectFundingSourceItemConfiguration : IEntityTypeConfiguration<ProjectFundingSourceItem>
{
    public void Configure(EntityTypeBuilder<ProjectFundingSourceItem> builder)
    {
        builder.IsMultiTenant();
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).HasMaxLength(100);
        builder.Property(x => x.LookupCategoryId);
    }
}
