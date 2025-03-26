using Ardalis.Specification;
using FSH.Framework.Core.Paging;
using FSH.Framework.Core.Specifications;
using budget_request_app.WebApi.CapitalProject.Infrastructure.SubModules.CapitalProjects.Get.v1;
using budget_request_app.WebApi.CapitalProject.Domain;

namespace budget_request_app.WebApi.CapitalProject.Infrastructure.SubModules.CapitalProjects.Search.v1;
public class SearchCapitalProjectSpecs : EntitiesByPaginationFilterSpec<CapitalProjectItem, CapitalProjectItem>
{
    public SearchCapitalProjectSpecs(SearchCapitalProjectsCommand command)
        : base(command) =>
        Query
            .OrderBy(c => c.Id, !command.HasOrderBy());
}
