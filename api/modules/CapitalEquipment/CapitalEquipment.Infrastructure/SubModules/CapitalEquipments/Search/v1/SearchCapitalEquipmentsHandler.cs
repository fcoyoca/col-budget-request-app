using FSH.Framework.Core.Paging;
using FSH.Framework.Core.Persistence;
using budget_request_app.WebApi.CapitalEquipment.Infrastructure.SubModules.CapitalEquipments.Get.v1;
using budget_request_app.WebApi.CapitalEquipment.Domain;
using MediatR;
using Microsoft.Extensions.DependencyInjection;


namespace budget_request_app.WebApi.CapitalEquipment.Infrastructure.SubModules.CapitalEquipments.Search.v1;
public sealed class SearchCapitalEquipmentsHandler(
    [FromKeyedServices("capitalEquipments")] IReadRepository<CapitalEquipmentItem> repository)
    : IRequestHandler<SearchCapitalEquipmentsCommand, PagedList<GetCapitalEquipmentResponseDefault>>
{
    public async Task<PagedList<GetCapitalEquipmentResponseDefault>> Handle(SearchCapitalEquipmentsCommand request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);

        var spec = new SearchCapitalEquipmentSpecs(request);

        var items = await repository.ListAsync(spec,cancellationToken).ConfigureAwait(false);
        var totalCount = await repository.CountAsync(spec, cancellationToken).ConfigureAwait(false);

        return new PagedList<GetCapitalEquipmentResponseDefault>(items, request!.PageNumber, request!.PageSize, totalCount);
    }
}

