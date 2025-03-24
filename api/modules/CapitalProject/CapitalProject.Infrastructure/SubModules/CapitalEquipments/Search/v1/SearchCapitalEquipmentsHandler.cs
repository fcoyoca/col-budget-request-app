using FSH.Framework.Core.Paging;
using FSH.Framework.Core.Persistence;
using budget_request_app.WebApi.CapitalEquipment.Infrastructure.SubModules.CapitalEquipments.Get.v1;
using budget_request_app.WebApi.CapitalEquipment.Domain;
using budget_request_app.WebApi.LookupValue.Domain;
using MediatR;
using Microsoft.Extensions.DependencyInjection;


namespace budget_request_app.WebApi.CapitalEquipment.Infrastructure.SubModules.CapitalEquipments.Search.v1;
public sealed class SearchCapitalEquipmentsHandler(
    [FromKeyedServices("capitalEquipments")] IReadRepository<CapitalEquipmentItem> repository,
    [FromKeyedServices("lookupValues")] IReadRepository<LookupValueItem> lookupRepository)
    : IRequestHandler<SearchCapitalEquipmentsCommand, PagedList<GetCapitalEquipmentResponse>>
{
    public async Task<PagedList<GetCapitalEquipmentResponse>> Handle(SearchCapitalEquipmentsCommand request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);

        var spec = new SearchCapitalEquipmentSpecs(request);

        var items = await repository.ListAsync(spec,cancellationToken).ConfigureAwait(false);
        var totalCount = await repository.CountAsync(spec, cancellationToken).ConfigureAwait(false);

        var lookupValues = await lookupRepository.ListAsync();

        var itemsMapped = items.Select(
            x => CapitalEquipmentMapper.GetResponse(x, lookupValues)
            );
        return new PagedList<GetCapitalEquipmentResponse>(itemsMapped.ToList(), request!.PageNumber, request!.PageSize, totalCount);
    }
}

