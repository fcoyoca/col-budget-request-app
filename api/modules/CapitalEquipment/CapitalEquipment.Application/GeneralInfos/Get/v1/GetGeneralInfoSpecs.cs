using Ardalis.Specification;
using budget_request_app.WebApi.CapitalEquipment.Domain;

namespace budget_request_app.WebApi.CapitalEquipment.Application.GeneralInfos.Get.v1;

public class GetGeneralInfoSpecs : Specification<GeneralInfo, GeneralInfoResponse>
{
    public GetGeneralInfoSpecs(Guid id)
    {
        Query
            .Where(p => p.Id == id);
    }
}
