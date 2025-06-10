using Ardalis.Specification;
using budget_request_app.WebApi.CapitalProject.Domain;

namespace budget_request_app.WebApi.CapitalProject.Infrastructure.SubModules.CapitalProjects.Get.v1;

public class GetCapitalProjectGeneralInfoByIdsSpec : Specification<CapitalProjectItem>
{
    public GetCapitalProjectGeneralInfoByIdsSpec(List<Guid> ids)
    {
        Query
            .Where(x => ids.Contains(x.Id))
            .Include(x => x.GeneralInformation);
    }
}
