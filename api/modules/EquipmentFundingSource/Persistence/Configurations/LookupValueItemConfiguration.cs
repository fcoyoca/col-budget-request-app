using Finbuckle.MultiTenant;
using budget_request_app.WebApi.EquipmentFundingSource.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace budget_request_app.WebApi.EquipmentFundingSource.Persistence.Configurations;
internal sealed class EquipmentFundingSourceItemConfiguration : IEntityTypeConfiguration<EquipmentFundingSourceItem>
{
    public void Configure(EntityTypeBuilder<EquipmentFundingSourceItem> builder)
    {
        builder.IsMultiTenant();
        builder.HasKey(x => x.Id);
    }
}
