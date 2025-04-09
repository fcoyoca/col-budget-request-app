using Ardalis.Specification;
using budget_request_app.WebApi.CapitalProject.Domain;
using budget_request_app.WebApi.CapitalProject.Infrastructure.SubModules.CapitalProjects.Search.v1;
using FSH.Framework.Core.Specifications;

namespace budget_request_app.WebApi.CapitalProject.Infrastructure.SubModules.CapitalProjects.Get.v1;

public class SearchCapitalProjectsSpec : Specification<CapitalProjectItem, CapitalProjectItem>
{
    public SearchCapitalProjectsSpec(SearchCapitalProjectsCommand command)
    {
        Query
            .Include(x => x.GeneralInformation)
            .Include(x => x.JustificationPrioritization)
            //.Skip((command.PageNumber - 1) * command.PageSize)
            //.Take(command.PageSize)
            ;
    }
}
