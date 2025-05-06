using Finbuckle.MultiTenant;
using budget_request_app.WebApi.BudgetYear.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace budget_request_app.WebApi.BudgetYear.Persistence.Configurations;
internal sealed class BudgetYearItemConfiguration : IEntityTypeConfiguration<BudgetYearItem>
{
    public void Configure(EntityTypeBuilder<BudgetYearItem> builder)
    {
        builder.IsMultiTenant();
        builder.HasKey(x => x.Id);
        builder.Property(x => x.BudgetYear);
    }
}
