using FSH.Framework.Core.Paging;
using FSH.Framework.Core.Persistence;
using FSH.Framework.Core.Specifications;
using budget_request_app.WebApi.ProjectBudgetIntroSectionOutlineItem.Domain;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace budget_request_app.WebApi.ProjectBudgetIntroSectionOutlineItem.Features.GetList.v1;

public sealed class GetProjectBudgetIntroSectionOutlineItemListHandler(
    [FromKeyedServices("ProjectBudgetIntroSectionOutlineItems")] IReadRepository<ProjectBudgetIntroSectionOutlineItemItem> repository)
    : IRequestHandler<GetProjectBudgetIntroSectionOutlineItemListRequest, PagedList<ProjectBudgetIntroSectionOutlineItemDto>>
{
    public async Task<PagedList<ProjectBudgetIntroSectionOutlineItemDto>> Handle(GetProjectBudgetIntroSectionOutlineItemListRequest request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);

        var spec = new EntitiesByPaginationFilterSpec<ProjectBudgetIntroSectionOutlineItemItem, ProjectBudgetIntroSectionOutlineItemDto>(request.Filter);

        var items = await repository.ListAsync(spec, cancellationToken).ConfigureAwait(false);

        var totalCount = await repository.CountAsync(spec, cancellationToken).ConfigureAwait(false);

        return new PagedList<ProjectBudgetIntroSectionOutlineItemDto>(items, request.Filter.PageNumber, request.Filter.PageSize, totalCount);
    }
}
