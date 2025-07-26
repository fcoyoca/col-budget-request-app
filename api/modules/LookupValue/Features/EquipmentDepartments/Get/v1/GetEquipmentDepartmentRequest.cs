using MediatR;

namespace budget_request_app.WebApi.LookupValue.Features.EquipmentDepartments.Get.v1;
public class GetEquipmentDepartmentRequest : IRequest<GetEquipmentDepartmentResponse>
{
    public Guid Id { get; set; }
    public GetEquipmentDepartmentRequest(Guid id) => Id = id;
}
