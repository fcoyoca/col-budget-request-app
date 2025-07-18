using MediatR;

namespace budget_request_app.WebApi.EquipmentDepartment.Features.Delete.v1;
public sealed record DeleteEquipmentDepartmentCommand(
    Guid Id) : IRequest;



