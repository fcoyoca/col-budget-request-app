using FSH.Framework.Core.Paging;
using MediatR;

namespace budget_request_app.WebApi.EquipmentFundingSource.Features.GetList.v1;
public record GetEquipmentFundingSourceListRequest(PaginationFilter Filter) : IRequest<PagedList<EquipmentFundingSourceDto>>;
