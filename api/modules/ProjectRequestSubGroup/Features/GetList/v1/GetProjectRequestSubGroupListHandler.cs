using FSH.Framework.Core.Paging;
using FSH.Framework.Core.Persistence;
using FSH.Framework.Core.Specifications;
using budget_request_app.WebApi.ProjectRequestSubGroup.Domain;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace budget_request_app.WebApi.ProjectRequestSubGroup.Features.GetList.v1;

public sealed class GetProjectRequestSubGroupListHandler(
    [FromKeyedServices("ProjectRequestSubGroups")] IReadRepository<ProjectRequestSubGroupItem> repository)
    : IRequestHandler<GetProjectRequestSubGroupListRequest, PagedList<ProjectRequestSubGroupDto>>
{
    public async Task<PagedList<ProjectRequestSubGroupDto>> Handle(GetProjectRequestSubGroupListRequest request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);

        var spec = new EntitiesByPaginationFilterSpec<ProjectRequestSubGroupItem, ProjectRequestSubGroupDto>(request.Filter);

        var items = await repository.ListAsync(spec, cancellationToken).ConfigureAwait(false);

        var totalCount = await repository.CountAsync(spec, cancellationToken).ConfigureAwait(false);

        return new PagedList<ProjectRequestSubGroupDto>(items, request.Filter.PageNumber, request.Filter.PageSize, totalCount);
    }
}
