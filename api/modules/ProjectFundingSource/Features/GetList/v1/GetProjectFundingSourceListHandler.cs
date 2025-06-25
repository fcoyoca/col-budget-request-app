using FSH.Framework.Core.Paging;
using FSH.Framework.Core.Persistence;
using FSH.Framework.Core.Specifications;
using budget_request_app.WebApi.ProjectFundingSource.Domain;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace budget_request_app.WebApi.ProjectFundingSource.Features.GetList.v1;

public sealed class GetProjectFundingSourceListHandler(
    [FromKeyedServices("ProjectFundingSources")] IReadRepository<ProjectFundingSourceItem> repository)
    : IRequestHandler<GetProjectFundingSourceListRequest, PagedList<ProjectFundingSourceDto>>
{
    public async Task<PagedList<ProjectFundingSourceDto>> Handle(GetProjectFundingSourceListRequest request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);

        var spec = new EntitiesByPaginationFilterSpec<ProjectFundingSourceItem, ProjectFundingSourceDto>(request.Filter);

        var items = await repository.ListAsync(spec, cancellationToken).ConfigureAwait(false);

        var totalCount = await repository.CountAsync(spec, cancellationToken).ConfigureAwait(false);

        return new PagedList<ProjectFundingSourceDto>(items, request.Filter.PageNumber, request.Filter.PageSize, totalCount);
    }
}
