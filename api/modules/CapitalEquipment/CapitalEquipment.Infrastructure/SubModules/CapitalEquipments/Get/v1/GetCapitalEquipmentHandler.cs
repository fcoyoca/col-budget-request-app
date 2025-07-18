using budget_request_app.WebApi.CapitalEquipment.Domain;
using budget_request_app.WebApi.CapitalEquipment.Domain.Exceptions;
using budget_request_app.WebApi.FileService.Domain;
using budget_request_app.WebApi.LookupValue.Domain;
using FSH.Framework.Core.Caching;
using FSH.Framework.Core.Identity.Users.Abstractions;
using FSH.Framework.Core.Persistence;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace budget_request_app.WebApi.CapitalEquipment.Infrastructure.SubModules.CapitalEquipments.Get.v1;
public sealed class GetCapitalEquipmentHandler(
    [FromKeyedServices("capitalEquipments")] IReadRepository<CapitalEquipmentItem> repository,
    [FromKeyedServices("lookupValues")] IReadRepository<LookupValueItem> lookupRepository,
    [FromKeyedServices("fileServices")] IReadRepository<FileServiceItem> fileRepository,
    IUserService userService,
    ICacheService cache)
    : IRequestHandler<GetCapitalEquipmentRequest, GetCapitalEquipmentResponse>
{
    public async Task<GetCapitalEquipmentResponse> Handle(GetCapitalEquipmentRequest request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);

        var users = await userService.GetListAsync(cancellationToken);
        var lookupValues = await lookupRepository.ListAsync();
        var files = await fileRepository.ListAsync();
        var capitalEquipmentItem = await repository.FirstOrDefaultAsync(new GetCapitalEquipmentByIdSpec(request.Id));
        if (capitalEquipmentItem == null) throw new CapitalEquipmentNotFoundException(request.Id);
        return CapitalEquipmentMapper.GetResponse(capitalEquipmentItem, lookupValues, files, users);
    }
}
