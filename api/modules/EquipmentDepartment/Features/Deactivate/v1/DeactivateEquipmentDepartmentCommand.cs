using budget_request_app.WebApi.EquipmentDepartment.Features.Activate.v1;
using MediatR;

namespace budget_request_app.WebApi.EquipmentDepartment.Features.Deactivate.v1;
public sealed record DeactivateEquipmentDepartmentCommand(
    Guid Id): IRequest<DeactivateEquipmentDepartmentResponse>;



