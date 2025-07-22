using Finbuckle.MultiTenant;
using budget_request_app.WebApi.ProjectExpenditureCategory.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace budget_request_app.WebApi.ProjectExpenditureCategory.Persistence.Configurations;
internal sealed class ProjectExpenditureCategoryItemConfiguration : IEntityTypeConfiguration<ProjectExpenditureCategoryItem>
{
    public void Configure(EntityTypeBuilder<ProjectExpenditureCategoryItem> builder)
    {
        builder.IsMultiTenant();
        builder.HasKey(x => x.Id);
    }
}
