using Ardalis.Specification;
using budget_request_app.WebApi.CapitalEquipment.Domain;

namespace budget_request_app.WebApi.CapitalEquipment.Infrastructure.SubModules.CapitalEquipments.Get.v1;

public class GetCapitalEquipmentSpecs : Specification<CapitalEquipmentItem, GetCapitalEquipmentResponse>
{
    public GetCapitalEquipmentSpecs(Guid id)
    {
        Query
            .Where(p => p.Id == id);
    }
}
