using FSH.Framework.Core.Paging;
using FSH.Framework.Core.Persistence;
using FSH.Framework.Core.Specifications;
using budget_request_app.WebApi.LookupValue.Domain;
using budget_request_app.WebApi.LookupCategory.Domain;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace budget_request_app.WebApi.LookupValue.Features.LookupValues.GetList.v1;

public sealed class GetLookupValueListHandler(
    [FromKeyedServices("lookupValues")] IReadRepository<LookupValueItem> repository, 
    [FromKeyedServices("lookupCategories")] IReadRepository<LookupCategoryItem> repositoryParent)
    : IRequestHandler<GetLookupValueListRequest, PagedList<LookupValueDto>>
{
    public async Task<PagedList<LookupValueDto>> Handle(GetLookupValueListRequest request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);

        var spec = new EntitiesByPaginationFilterSpec<LookupValueItem, LookupValueDto>(request.Filter);

        var categories = await repositoryParent.ListAsync();

        var items = await repository.ListAsync(spec, cancellationToken).ConfigureAwait(false);

        foreach (var item in items)
        {
            var category = categories.FirstOrDefault(x => x.Id == item.LookupCategoryId);
            if (category == null)
            {
                continue;
            }

            var catName = category.Name;
            var propCatName = item.GetType().GetProperty("LookupCategoryName");
            propCatName.SetValue(item, catName);
        }

        var totalCount = await repository.CountAsync(spec, cancellationToken).ConfigureAwait(false);

        return new PagedList<LookupValueDto>(items, request.Filter.PageNumber, request.Filter.PageSize, totalCount);
    }
}
