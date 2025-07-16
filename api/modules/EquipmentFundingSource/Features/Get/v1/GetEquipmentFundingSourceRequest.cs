using MediatR;

namespace budget_request_app.WebApi.EquipmentFundingSource.Features.Get.v1;
public class GetEquipmentFundingSourceRequest : IRequest<GetEquipmentFundingSourceResponse>
{
    public Guid Id { get; set; }
    public GetEquipmentFundingSourceRequest(Guid id) => Id = id;
}
