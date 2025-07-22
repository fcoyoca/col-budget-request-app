using FSH.Framework.Core.Paging;
using FSH.Framework.Core.Persistence;
using FSH.Framework.Core.Specifications;
using budget_request_app.WebApi.ProjectExpenditureCategory.Domain;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace budget_request_app.WebApi.ProjectExpenditureCategory.Features.GetList.v1;

public sealed class GetProjectExpenditureCategoryListHandler(
    [FromKeyedServices("ProjectExpenditureCategories")] IReadRepository<ProjectExpenditureCategoryItem> repository)
    : IRequestHandler<GetProjectExpenditureCategoryListRequest, PagedList<ProjectExpenditureCategoryDto>>
{
    public async Task<PagedList<ProjectExpenditureCategoryDto>> Handle(GetProjectExpenditureCategoryListRequest request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);

        var spec = new EntitiesByPaginationFilterSpec<ProjectExpenditureCategoryItem, ProjectExpenditureCategoryDto>(request.Filter);

        var items = await repository.ListAsync(spec, cancellationToken).ConfigureAwait(false);

        var totalCount = await repository.CountAsync(spec, cancellationToken).ConfigureAwait(false);

        return new PagedList<ProjectExpenditureCategoryDto>(items, request.Filter.PageNumber, request.Filter.PageSize, totalCount);
    }
}
