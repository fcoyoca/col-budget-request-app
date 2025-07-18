using Finbuckle.MultiTenant;
using budget_request_app.WebApi.EquipmentDepartment.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace budget_request_app.WebApi.EquipmentDepartment.Persistence.Configurations;
internal sealed class EquipmentDepartmentItemConfiguration : IEntityTypeConfiguration<EquipmentDepartmentItem>
{
    public void Configure(EntityTypeBuilder<EquipmentDepartmentItem> builder)
    {
        builder.IsMultiTenant();
        builder.HasKey(x => x.Id);
    }
}
