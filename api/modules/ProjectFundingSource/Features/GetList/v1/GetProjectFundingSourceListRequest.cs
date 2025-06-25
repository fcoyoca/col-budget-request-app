using FSH.Framework.Core.Paging;
using MediatR;

namespace budget_request_app.WebApi.ProjectFundingSource.Features.GetList.v1;
public record GetProjectFundingSourceListRequest(PaginationFilter Filter) : IRequest<PagedList<ProjectFundingSourceDto>>;
