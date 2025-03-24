using Finbuckle.MultiTenant;
using budget_request_app.WebApi.CapitalProject.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace budget_request_app.WebApi.CapitalProject.Infrastructure.Persistence.Configurations;
internal sealed class CapitalProjectRequestConfiguration : IEntityTypeConfiguration<CapitalProjectItem>
{
    public void Configure(EntityTypeBuilder<CapitalProjectItem> builder)
    {
        builder.IsMultiTenant();
        builder.HasKey(x => x.Id);
    }
}

