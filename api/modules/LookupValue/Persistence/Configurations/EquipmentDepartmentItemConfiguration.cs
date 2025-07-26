using Finbuckle.MultiTenant;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using budget_request_app.WebApi.LookupValue.Domain;

namespace budget_request_app.WebApi.LookupValue.Persistence.Configurations;
internal sealed class EquipmentDepartmentItemConfiguration : IEntityTypeConfiguration<EquipmentDepartmentItem>
{
    public void Configure(EntityTypeBuilder<EquipmentDepartmentItem> builder)
    {
        builder.IsMultiTenant();
        builder.HasKey(x => x.Id);
    }
}
