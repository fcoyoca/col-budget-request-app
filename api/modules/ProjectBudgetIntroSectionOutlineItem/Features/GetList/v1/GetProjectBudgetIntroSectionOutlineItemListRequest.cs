using FSH.Framework.Core.Paging;
using MediatR;

namespace budget_request_app.WebApi.ProjectBudgetIntroSectionOutlineItem.Features.GetList.v1;
public record GetProjectBudgetIntroSectionOutlineItemListRequest(PaginationFilter Filter) : IRequest<PagedList<ProjectBudgetIntroSectionOutlineItemDto>>;
