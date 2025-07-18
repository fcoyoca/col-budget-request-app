using FSH.Framework.Core.Paging;
using FSH.Framework.Core.Persistence;
using FSH.Framework.Core.Specifications;
using budget_request_app.WebApi.EquipmentDepartment.Domain;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace budget_request_app.WebApi.EquipmentDepartment.Features.GetList.v1;

public sealed class GetEquipmentDepartmentListHandler(
    [FromKeyedServices("EquipmentDepartments")] IReadRepository<EquipmentDepartmentItem> repository)
    : IRequestHandler<GetEquipmentDepartmentListRequest, PagedList<EquipmentDepartmentDto>>
{
    public async Task<PagedList<EquipmentDepartmentDto>> Handle(GetEquipmentDepartmentListRequest request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);

        var spec = new EntitiesByPaginationFilterSpec<EquipmentDepartmentItem, EquipmentDepartmentDto>(request.Filter);

        var items = await repository.ListAsync(spec, cancellationToken).ConfigureAwait(false);

        var totalCount = await repository.CountAsync(spec, cancellationToken).ConfigureAwait(false);

        return new PagedList<EquipmentDepartmentDto>(items, request.Filter.PageNumber, request.Filter.PageSize, totalCount);
    }
}
