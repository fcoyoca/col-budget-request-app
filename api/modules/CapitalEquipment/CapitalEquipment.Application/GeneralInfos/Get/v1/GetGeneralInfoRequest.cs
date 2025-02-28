using MediatR;

namespace budget_request_app.WebApi.CapitalEquipment.Application.GeneralInfos.Get.v1;
public class GetGeneralInfoRequest : IRequest<GeneralInfoResponse>
{
    public Guid Id { get; set; }
    public GetGeneralInfoRequest(Guid id) => Id = id;
}
