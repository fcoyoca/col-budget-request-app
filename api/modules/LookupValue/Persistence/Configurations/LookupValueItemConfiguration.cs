using Finbuckle.MultiTenant;
using budget_request_app.WebApi.LookupValue.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace budget_request_app.WebApi.LookupValue.Persistence.Configurations;
internal sealed class LookupValueItemConfiguration : IEntityTypeConfiguration<LookupValueItem>
{
    public void Configure(EntityTypeBuilder<LookupValueItem> builder)
    {
        builder.IsMultiTenant();
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).HasMaxLength(100);
        builder.Property(x => x.LookupCategoryId);
    }
}
