using FSH.Framework.Core.Paging;
using MediatR;

namespace budget_request_app.WebApi.ProjectRequestGroup.Features.GetList.v1;
public record GetProjectRequestGroupListRequest(PaginationFilter Filter) : IRequest<PagedList<ProjectRequestGroupDto>>;
