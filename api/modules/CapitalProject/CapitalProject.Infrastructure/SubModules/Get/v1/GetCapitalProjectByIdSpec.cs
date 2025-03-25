using Ardalis.Specification;
using budget_request_app.WebApi.CapitalProject.Domain;

namespace budget_request_app.WebApi.CapitalProject.Infrastructure.SubModules.CapitalProjects.Get.v1;

public class GetCapitalProjectByIdSpec : Specification<CapitalProjectItem, CapitalProjectItem>
{
    public GetCapitalProjectByIdSpec(Guid id)
    {
        Query
            .Where(p => p.Id == id)
            .Include(x => x.GeneralInformation)
            .Include(x => x.JustificationPrioritization);
    }
}
