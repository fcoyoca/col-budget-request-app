using Finbuckle.MultiTenant;
using budget_request_app.WebApi.ProjectBudgetIntroSectionOutlineItem.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace budget_request_app.WebApi.ProjectBudgetIntroSectionOutlineItem.Persistence.Configurations;
internal sealed class ProjectBudgetIntroSectionOutlineItemItemConfiguration : IEntityTypeConfiguration<ProjectBudgetIntroSectionOutlineItemItem>
{
    public void Configure(EntityTypeBuilder<ProjectBudgetIntroSectionOutlineItemItem> builder)
    {
        builder.IsMultiTenant();
        builder.HasKey(x => x.Id);
    }
}
