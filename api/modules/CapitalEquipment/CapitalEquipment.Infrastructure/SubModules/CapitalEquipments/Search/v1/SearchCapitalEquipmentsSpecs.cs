using Ardalis.Specification;
using budget_request_app.WebApi.CapitalEquipment.Domain;
using FSH.Framework.Core.Paging;
using FSH.Framework.Core.Specifications;

namespace budget_request_app.WebApi.CapitalEquipment.Infrastructure.SubModules.CapitalEquipments.Search.v1;
public class SearchCapitalEquipmentSpecs : EntitiesByPaginationFilterSpec<CapitalEquipmentItem>
{
    public SearchCapitalEquipmentSpecs(SearchCapitalEquipmentsCommand command, Guid currentUserId, bool canViewAll)
        : base(command) =>
        Query
            .Where(p =>
                canViewAll ||
                !p.IsDraft ||
                (p.IsDraft && p.CreatedBy == currentUserId))
            .Include(x => x.FundingItems)
                .ThenInclude(x => x.YearEstimates)
            .Include(x => x.FundingItems)
                .ThenInclude(x => x.CurrentYearRequested)
            .Include(x => x.PastFundings)
            .OrderBy(c => c.Id, !command.HasOrderBy());
}
