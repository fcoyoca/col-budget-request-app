using Ardalis.Specification;
using FSH.Framework.Core.Paging;
using FSH.Framework.Core.Specifications;
using budget_request_app.WebApi.CapitalEquipment.Application.GeneralInfos.Get.v1;
using budget_request_app.WebApi.CapitalEquipment.Domain;

namespace budget_request_app.WebApi.CapitalEquipment.Application.GeneralInfos.Search.v1;
public class SearchGeneralInfoSpecs : EntitiesByPaginationFilterSpec<GeneralInfo, GeneralInfoResponse>
{
    public SearchGeneralInfoSpecs(SearchGeneralInfosCommand command)
        : base(command) =>
        Query
            .OrderBy(c => c.Id, !command.HasOrderBy());
}
