using Azure.Core;
using Microsoft.Extensions.DependencyInjection;
using budget_request_app.WebApi.CapitalEquipment.Domain.Exceptions;
using FSH.Framework.Core.Persistence;
using FSH.Framework.Core.Caching;
using budget_request_app.WebApi.CapitalEquipment.Domain;
using budget_request_app.WebApi.CapitalEquipment.Infrastructure.SubModules.CapitalEquipments.Create.v1;
using budget_request_app.WebApi.LookupValue.Domain;
using MediatR;

namespace budget_request_app.WebApi.CapitalEquipment.Infrastructure.SubModules.CapitalEquipments.Get.v1;
public sealed class GetCapitalEquipmentHandler(
    [FromKeyedServices("capitalEquipments")] IReadRepository<CapitalEquipmentItem> repository,
    [FromKeyedServices("lookupValues")] IReadRepository<LookupValueItem> lookupRepository,
    ICacheService cache)
    : IRequestHandler<GetCapitalEquipmentRequest, GetCapitalEquipmentResponse>
{
    public async Task<GetCapitalEquipmentResponse> Handle(GetCapitalEquipmentRequest request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        
        var lookupValues = await lookupRepository.ListAsync();

        var item = await cache.GetOrSetAsync(
            $"CapitalEquipment:{request.Id}",
            async () =>
            {
                var capitalEquipmentItem = await repository.FirstOrDefaultAsync(new GetCapitalEquipmentByIdSpec(request.Id));
                //var capitalEquipmentItem = await repository.GetByIdAsync(request.Id, cancellationToken);
                if (capitalEquipmentItem == null) throw new CapitalEquipmentNotFoundException(request.Id);
                return CapitalEquipmentMapper.GetResponse(capitalEquipmentItem,lookupValues);
            },
            cancellationToken: cancellationToken);
        
        return item;
    }

    
}
