using FSH.Framework.Core.Paging;
using MediatR;

namespace budget_request_app.WebApi.LookupValue.Features.LookupValues.GetList.v1;
public record GetLookupValueListRequest(PaginationFilter Filter) : IRequest<PagedList<LookupValueDto>>;
