using Ardalis.Specification;
using FSH.Framework.Core.Paging;
using FSH.Framework.Core.Specifications;
using budget_request_app.WebApi.CapitalEquipment.Infrastructure.SubModules.CapitalEquipments.Get.v1;
using budget_request_app.WebApi.CapitalEquipment.Domain;

namespace budget_request_app.WebApi.CapitalEquipment.Infrastructure.SubModules.CapitalEquipments.Search.v1;
public class SearchCapitalEquipmentSpecs : EntitiesByPaginationFilterSpec<CapitalEquipmentItem, GetCapitalEquipmentResponseDefault>
{
    public SearchCapitalEquipmentSpecs(SearchCapitalEquipmentsCommand command)
        : base(command) =>
        Query
            .OrderBy(c => c.Id, !command.HasOrderBy());
}
