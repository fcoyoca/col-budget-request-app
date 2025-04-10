using Ardalis.Specification;
using budget_request_app.WebApi.CapitalProject.Domain;
using budget_request_app.WebApi.CapitalProject.Infrastructure.SubModules.CapitalProjects.Search.v1;
using FSH.Framework.Core.Paging;
using FSH.Framework.Core.Specifications;

namespace budget_request_app.WebApi.CapitalProject.Infrastructure.SubModules.CapitalProjects.Get.v1;

public class SearchCapitalProjectsSpec : EntitiesByPaginationFilterSpec<CapitalProjectItem>
{
    public SearchCapitalProjectsSpec(SearchCapitalProjectsCommand command)
        : base(command) =>
        Query
            .Include(x => x.GeneralInformation)
            .Include(x => x.JustificationPrioritization)
            .OrderBy(c => c.Id, !command.HasOrderBy());
}
