using FSH.Framework.Core.Paging;
using MediatR;

namespace budget_request_app.WebApi.LookupCategory.Features.GetList.v1;
public record GetLookupCategoryListRequest(PaginationFilter Filter) : IRequest<PagedList<LookupCategoryDto>>;
