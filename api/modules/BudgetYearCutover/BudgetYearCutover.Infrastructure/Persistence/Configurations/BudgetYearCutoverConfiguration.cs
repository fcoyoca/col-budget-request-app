using BudgetYearCutover.Domain;
using Finbuckle.MultiTenant;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BudgetYearCutover.Infrastructure.Persistence.Configurations;

public class BudgetYearCutoverConfiguration : IEntityTypeConfiguration<CutoverReportCover>
{
    public void Configure(EntityTypeBuilder<CutoverReportCover> builder)
    {
        builder.IsMultiTenant();
        builder.HasKey(p => p.Id);
    }
}
