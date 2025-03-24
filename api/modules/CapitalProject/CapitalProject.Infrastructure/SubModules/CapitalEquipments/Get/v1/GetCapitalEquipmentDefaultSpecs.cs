using Ardalis.Specification;
using budget_request_app.WebApi.CapitalEquipment.Domain;

namespace budget_request_app.WebApi.CapitalEquipment.Infrastructure.SubModules.CapitalEquipments.Get.v1;

public class GetCapitalEquipmentDefaultSpecs : Specification<CapitalEquipmentItem, GetCapitalEquipmentResponse>
{
    public GetCapitalEquipmentDefaultSpecs(Guid id)
    {
        Query
            .Where(p => p.Id == id);
    }
}
