using MediatR;

namespace budget_request_app.WebApi.LookupValue.Features.EquipmentDepartments.Deactivate.v1;
public sealed record DeactivateEquipmentDepartmentCommand(
    Guid Id) : IRequest<DeactivateEquipmentDepartmentResponse>;



