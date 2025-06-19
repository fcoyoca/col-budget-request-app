using Ardalis.Specification;
using FSH.Framework.Core.Paging;
using FSH.Framework.Core.Specifications;
using budget_request_app.WebApi.CapitalEquipment.Infrastructure.SubModules.CapitalEquipments.Get.v1;
using budget_request_app.WebApi.CapitalEquipment.Domain;

namespace budget_request_app.WebApi.CapitalEquipment.Infrastructure.SubModules.CapitalEquipments.Search.v1;
public class SearchCapitalEquipmentSpecs : EntitiesByPaginationFilterSpec<CapitalEquipmentItem>
{
    public SearchCapitalEquipmentSpecs(SearchCapitalEquipmentsCommand command)
        : base(command) =>
        Query
            .Include(x => x.FundingItems)
            .ThenInclude(x => x.YearEstimates)
            .Include(x => x.FundingItems)
            .ThenInclude(x => x.CurrentYearRequested)
            //.Include(x => x.PastFundings)
            .OrderBy(c => c.Id, !command.HasOrderBy());
}
