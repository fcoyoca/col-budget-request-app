using FSH.Framework.Core.Paging;
using MediatR;

namespace budget_request_app.WebApi.EquipmentDepartment.Features.GetList.v1;
public record GetEquipmentDepartmentListRequest(PaginationFilter Filter) : IRequest<PagedList<EquipmentDepartmentDto>>;
