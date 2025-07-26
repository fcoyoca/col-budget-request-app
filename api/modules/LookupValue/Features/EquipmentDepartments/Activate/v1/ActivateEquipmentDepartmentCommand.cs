using MediatR;

namespace budget_request_app.WebApi.LookupValue.Features.EquipmentDepartments.Activate.v1;
public sealed record ActivateEquipmentDepartmentCommand(
    Guid? Id): IRequest<ActivateEquipmentDepartmentResponse>;



