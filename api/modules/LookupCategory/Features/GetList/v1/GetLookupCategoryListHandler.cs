using FSH.Framework.Core.Paging;
using FSH.Framework.Core.Persistence;
using FSH.Framework.Core.Specifications;
using budget_request_app.WebApi.LookupCategory.Domain;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace budget_request_app.WebApi.LookupCategory.Features.GetList.v1;

public sealed class GetLookupCategoryListHandler(
    [FromKeyedServices("lookupCategories")] IReadRepository<LookupCategoryItem> repository)
    : IRequestHandler<GetLookupCategoryListRequest, PagedList<LookupCategoryDto>>
{
    public async Task<PagedList<LookupCategoryDto>> Handle(GetLookupCategoryListRequest request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);

        var spec = new EntitiesByPaginationFilterSpec<LookupCategoryItem, LookupCategoryDto>(request.Filter);

        var items = await repository.ListAsync(spec, cancellationToken).ConfigureAwait(false);
        var totalCount = await repository.CountAsync(spec, cancellationToken).ConfigureAwait(false);

        return new PagedList<LookupCategoryDto>(items, request.Filter.PageNumber, request.Filter.PageSize, totalCount);
    }
}
