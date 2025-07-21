using FSH.Framework.Core.Paging;
using FSH.Framework.Core.Persistence;
using FSH.Framework.Core.Specifications;
using budget_request_app.WebApi.ProjectRequestGroup.Domain;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace budget_request_app.WebApi.ProjectRequestGroup.Features.GetList.v1;

public sealed class GetProjectRequestGroupListHandler(
    [FromKeyedServices("ProjectRequestGroups")] IReadRepository<ProjectRequestGroupItem> repository)
    : IRequestHandler<GetProjectRequestGroupListRequest, PagedList<ProjectRequestGroupDto>>
{
    public async Task<PagedList<ProjectRequestGroupDto>> Handle(GetProjectRequestGroupListRequest request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);

        var spec = new EntitiesByPaginationFilterSpec<ProjectRequestGroupItem, ProjectRequestGroupDto>(request.Filter);

        var items = await repository.ListAsync(spec, cancellationToken).ConfigureAwait(false);

        var totalCount = await repository.CountAsync(spec, cancellationToken).ConfigureAwait(false);

        return new PagedList<ProjectRequestGroupDto>(items, request.Filter.PageNumber, request.Filter.PageSize, totalCount);
    }
}
