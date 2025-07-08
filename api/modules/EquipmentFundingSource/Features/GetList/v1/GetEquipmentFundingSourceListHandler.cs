using FSH.Framework.Core.Paging;
using FSH.Framework.Core.Persistence;
using FSH.Framework.Core.Specifications;
using budget_request_app.WebApi.EquipmentFundingSource.Domain;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace budget_request_app.WebApi.EquipmentFundingSource.Features.GetList.v1;

public sealed class GetEquipmentFundingSourceListHandler(
    [FromKeyedServices("ProjectFundingSources")] IReadRepository<EquipmentFundingSourceItem> repository)
    : IRequestHandler<GetEquipmentFundingSourceListRequest, PagedList<EquipmentFundingSourceDto>>
{
    public async Task<PagedList<EquipmentFundingSourceDto>> Handle(GetEquipmentFundingSourceListRequest request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);

        var spec = new EntitiesByPaginationFilterSpec<EquipmentFundingSourceItem, EquipmentFundingSourceDto>(request.Filter);

        var items = await repository.ListAsync(spec, cancellationToken).ConfigureAwait(false);

        var totalCount = await repository.CountAsync(spec, cancellationToken).ConfigureAwait(false);

        return new PagedList<EquipmentFundingSourceDto>(items, request.Filter.PageNumber, request.Filter.PageSize, totalCount);
    }
}
