using FSH.Framework.Core.Paging;
using budget_request_app.WebApi.CapitalEquipment.Application.GeneralInfos.Get.v1;
using MediatR;

namespace budget_request_app.WebApi.CapitalEquipment.Application.GeneralInfos.Search.v1;

public class SearchGeneralInfosCommand : PaginationFilter, IRequest<PagedList<GeneralInfoResponse>>
{
}
