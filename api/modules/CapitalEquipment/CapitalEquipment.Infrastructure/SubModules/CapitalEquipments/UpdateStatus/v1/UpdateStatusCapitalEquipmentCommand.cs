using MediatR;

namespace budget_request_app.WebApi.CapitalEquipment.Infrastructure.SubModules.CapitalEquipments.UpdateStatus.v1;
public sealed record UpdateStatusCapitalEquipmentCommand(
    List<Guid> Ids,
    Guid StatusId
    ) : IRequest<UpdateStatusCapitalEquipmentResponse>;
