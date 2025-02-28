using Finbuckle.MultiTenant;
using budget_request_app.WebApi.CapitalEquipment.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace budget_request_app.WebApi.CapitalEquipment.Infrastructure.Persistence.Configurations;
internal sealed class GeneralInfoConfiguration : IEntityTypeConfiguration<GeneralInfo>
{
    public void Configure(EntityTypeBuilder<GeneralInfo> builder)
    {
        builder.IsMultiTenant();
        builder.HasKey(x => x.Id);
    }
}
