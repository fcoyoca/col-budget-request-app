using FSH.Framework.Core.Storage.File;
using FSH.Framework.Core.Storage.File.Features;

namespace FSH.Framework.Core.Storage;

public interface IStorageService
{
    public Task<Uri> UploadAsync<T>(FileUploadCommand? request, FileType supportedFileType, CancellationToken cancellationToken = default)
    where T : class;

    public Task<Uri> UploadAttachmentAsync(FileUploadCommand? request, FileType supportedFileType,
        CancellationToken cancellationToken = default);

    public void Remove(Uri? path);
}
