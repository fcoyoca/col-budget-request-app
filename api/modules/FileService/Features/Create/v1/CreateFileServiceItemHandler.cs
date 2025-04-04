using budget_request_app.WebApi.CapitalEquipment.Domain;
using budget_request_app.WebApi.CapitalProject.Domain;
using FSH.Framework.Core.Persistence;
using budget_request_app.WebApi.FileService.Domain;
using FSH.Framework.Core.Jobs;
using FSH.Framework.Core.Storage;
using FSH.Framework.Core.Storage.File;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.FileService.Features.Create.v1;
public sealed class CreateFileServiceHandler(
    ILogger<CreateFileServiceHandler> logger,
    IStorageService storageService,
    IJobService hangfireService,
    [FromKeyedServices("capitalEquipments")] IRepository<CapitalEquipmentItem> repositoryEquipment,
    [FromKeyedServices("capitalProjects")] IRepository<CapitalProjectItem> repositoryProject,
    [FromKeyedServices("fileServices")] IRepository<FileServiceItem> repository)
    : IRequestHandler<CreateFileServiceItemCommand, CreateFileServiceItemResponse>
{
    public async Task<CreateFileServiceItemResponse> Handle(CreateFileServiceItemCommand request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        var uploadedFile = await storageService.UploadAttachmentAsync(request.File, FileType.Image, cancellationToken);

        var fileName = Path.GetFileName(uploadedFile.ToString());
        var name = Path.GetFileNameWithoutExtension(uploadedFile.ToString());
        
        var item = FileServiceItem.Create(name,fileName);
        await repository.AddAsync(item, cancellationToken).ConfigureAwait(false);
        await repository.SaveChangesAsync(cancellationToken).ConfigureAwait(false);
        logger.LogInformation("FileService item created {FileServiceItemId}", item.Id);
        
        hangfireService.Schedule(() => CheckFileIfUsed(item.Id), TimeSpan.FromMinutes(10));
        
        return new CreateFileServiceItemResponse(item.Id);
    }

    public async Task CheckFileIfUsed(Guid fileid)
    {
        var equipments = await repositoryEquipment.ListAsync();
        
        var hasEquipment = equipments.Any(x => x.FileIds.Contains(fileid.ToString()));

        if (!hasEquipment)
        {
            var file = await repository.GetByIdAsync(fileid);
            await repository.DeleteAsync(file);
            storageService.RemoveAttachment(file.FileName);
        }
    }
}
