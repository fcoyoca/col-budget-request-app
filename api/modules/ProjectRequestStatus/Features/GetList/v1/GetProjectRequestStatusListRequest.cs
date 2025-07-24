using FSH.Framework.Core.Paging;
using MediatR;

namespace budget_request_app.WebApi.ProjectRequestStatus.Features.GetList.v1;
public record GetProjectRequestStatusListRequest(PaginationFilter Filter) : IRequest<PagedList<ProjectRequestStatusDto>>;
