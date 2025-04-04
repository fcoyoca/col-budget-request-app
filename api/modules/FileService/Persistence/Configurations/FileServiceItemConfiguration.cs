using Finbuckle.MultiTenant;
using budget_request_app.WebApi.FileService.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace budget_request_app.WebApi.FileService.Persistence.Configurations;
internal sealed class FileServiceItemConfiguration : IEntityTypeConfiguration<FileServiceItem>
{
    public void Configure(EntityTypeBuilder<FileServiceItem> builder)
    {
        builder.IsMultiTenant();
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).HasMaxLength(100);
    }
}
