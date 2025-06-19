using Finbuckle.MultiTenant;
using budget_request_app.WebApi.CapitalEquipment.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace budget_request_app.WebApi.CapitalEquipment.Infrastructure.Persistence.Configurations;
internal sealed class CapitalEquipmentRequestConfiguration : IEntityTypeConfiguration<CapitalEquipmentItem>
{
    public void Configure(EntityTypeBuilder<CapitalEquipmentItem> builder)
    {
        builder.IsMultiTenant();
        builder.HasKey(x => x.Id);
        builder.HasMany<FundingItem>(x => x.FundingItems)
            .WithOne(x => x.CapitalEquipment)
            .HasForeignKey(x => x.CapitalEquipmentId);
        
    }
}

internal sealed class FundingConfiguration : IEntityTypeConfiguration<FundingItem>
{
    public void Configure(EntityTypeBuilder<FundingItem> builder)
    {
        builder.IsMultiTenant();
        builder.HasKey(x => x.Id);
    }
}

