using Ardalis.Specification;
using budget_request_app.WebApi.CapitalEquipment.Domain;

namespace budget_request_app.WebApi.CapitalEquipment.Infrastructure.SubModules.CapitalEquipments.Get.v1;

public class GetCapitalEquipmentByIdSpec : Specification<CapitalEquipmentItem>
{
    public GetCapitalEquipmentByIdSpec(Guid id)
    {
        Query
            .Where(p => p.Id == id)
            .Include(x => x.FundingItems)
            .ThenInclude(x => x.CurrentYearRequested)
            .Include(x => x.FundingItems)
            .ThenInclude(x => x.YearEstimates);
    }
}
