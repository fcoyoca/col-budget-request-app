using FSH.Framework.Core.Paging;
using MediatR;

namespace budget_request_app.WebApi.ProjectRequestSubGroup.Features.GetList.v1;
public record GetProjectRequestSubGroupListRequest(PaginationFilter Filter) : IRequest<PagedList<ProjectRequestSubGroupDto>>;
