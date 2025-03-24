using MediatR;

namespace budget_request_app.WebApi.CapitalEquipment.Infrastructure.SubModules.CapitalEquipments.Get.v1;
public class GetCapitalEquipmentRequest : IRequest<GetCapitalEquipmentResponse>
{
    public Guid Id { get; set; }
    public GetCapitalEquipmentRequest(Guid id) => Id = id;
}
