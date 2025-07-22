using FSH.Framework.Core.Paging;
using FSH.Framework.Core.Persistence;
using FSH.Framework.Core.Specifications;
using budget_request_app.WebApi.ProjectRequestStatus.Domain;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace budget_request_app.WebApi.ProjectRequestStatus.Features.GetList.v1;

public sealed class GetProjectRequestStatusListHandler(
    [FromKeyedServices("ProjectRequestStatuses")] IReadRepository<ProjectRequestStatusItem> repository)
    : IRequestHandler<GetProjectRequestStatusListRequest, PagedList<ProjectRequestStatusDto>>
{
    public async Task<PagedList<ProjectRequestStatusDto>> Handle(GetProjectRequestStatusListRequest request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);

        var spec = new EntitiesByPaginationFilterSpec<ProjectRequestStatusItem, ProjectRequestStatusDto>(request.Filter);

        var items = await repository.ListAsync(spec, cancellationToken).ConfigureAwait(false);

        var totalCount = await repository.CountAsync(spec, cancellationToken).ConfigureAwait(false);

        return new PagedList<ProjectRequestStatusDto>(items, request.Filter.PageNumber, request.Filter.PageSize, totalCount);
    }
}
