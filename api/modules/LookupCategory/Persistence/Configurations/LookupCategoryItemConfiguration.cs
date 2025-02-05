using Finbuckle.MultiTenant;
using budget_request_app.WebApi.LookupCategory.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace budget_request_app.WebApi.LookupCategory.Persistence.Configurations;
internal sealed class LookupCategoryItemConfiguration : IEntityTypeConfiguration<LookupCategoryItem>
{
    public void Configure(EntityTypeBuilder<LookupCategoryItem> builder)
    {
        builder.IsMultiTenant();
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).HasMaxLength(100);
        builder.Property(x => x.Description).HasMaxLength(1000);
    }
}
