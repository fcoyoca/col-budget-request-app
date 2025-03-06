using FSH.Framework.Core.Paging;
using budget_request_app.WebApi.CapitalEquipment.Infrastructure.SubModules.CapitalEquipments.Get.v1;
using MediatR;

namespace budget_request_app.WebApi.CapitalEquipment.Infrastructure.SubModules.CapitalEquipments.Search.v1;

public class SearchCapitalEquipmentsCommand : PaginationFilter, IRequest<PagedList<GetCapitalEquipmentResponseDefault>>
{
}
