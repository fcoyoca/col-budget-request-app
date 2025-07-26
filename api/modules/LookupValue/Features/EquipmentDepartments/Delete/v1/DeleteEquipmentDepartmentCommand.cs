using MediatR;

namespace budget_request_app.WebApi.LookupValue.Features.EquipmentDepartments.Delete.v1;
public sealed record DeleteEquipmentDepartmentCommand(
    Guid Id) : IRequest;



