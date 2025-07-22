using FSH.Framework.Core.Paging;
using MediatR;

namespace budget_request_app.WebApi.ProjectExpenditureCategory.Features.GetList.v1;
public record GetProjectExpenditureCategoryListRequest(PaginationFilter Filter) : IRequest<PagedList<ProjectExpenditureCategoryDto>>;
