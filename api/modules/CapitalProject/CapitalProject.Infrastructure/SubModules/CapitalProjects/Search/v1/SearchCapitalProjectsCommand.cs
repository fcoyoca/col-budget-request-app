using FSH.Framework.Core.Paging;
using budget_request_app.WebApi.CapitalProject.Infrastructure.SubModules.CapitalProjects.Get.v1;
using MediatR;

namespace budget_request_app.WebApi.CapitalProject.Infrastructure.SubModules.CapitalProjects.Search.v1;

public class SearchCapitalProjectsCommand : PaginationFilter, IRequest<PagedList<GetCapitalProjectResponse>>
{
}
