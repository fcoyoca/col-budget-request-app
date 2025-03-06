using MediatR;

namespace budget_request_app.WebApi.CapitalEquipment.Infrastructure.SubModules.CapitalEquipments.Delete.v1;
public sealed record DeleteCapitalEquipmentCommand(
    Guid Id) : IRequest;
