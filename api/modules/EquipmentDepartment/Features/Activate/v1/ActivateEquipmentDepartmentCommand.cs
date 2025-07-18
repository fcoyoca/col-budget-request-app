using MediatR;

namespace budget_request_app.WebApi.EquipmentDepartment.Features.Activate.v1;
public sealed record ActivateEquipmentDepartmentCommand(
    Guid? Id): IRequest<ActivateEquipmentDepartmentResponse>;



