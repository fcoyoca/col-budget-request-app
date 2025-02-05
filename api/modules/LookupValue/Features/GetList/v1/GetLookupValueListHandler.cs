using FSH.Framework.Core.Paging;
using FSH.Framework.Core.Persistence;
using FSH.Framework.Core.Specifications;
using budget_request_app.WebApi.LookupValue.Domain;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace budget_request_app.WebApi.LookupValue.Features.GetList.v1;

public sealed class GetLookupValueListHandler(
    [FromKeyedServices("lookupValues")] IReadRepository<LookupValueItem> repository)
    : IRequestHandler<GetLookupValueListRequest, PagedList<LookupValueDto>>
{
    public async Task<PagedList<LookupValueDto>> Handle(GetLookupValueListRequest request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);

        var spec = new EntitiesByPaginationFilterSpec<LookupValueItem, LookupValueDto>(request.Filter);

        var items = await repository.ListAsync(spec, cancellationToken).ConfigureAwait(false);
        var totalCount = await repository.CountAsync(spec, cancellationToken).ConfigureAwait(false);

        return new PagedList<LookupValueDto>(items, request.Filter.PageNumber, request.Filter.PageSize, totalCount);
    }
}
