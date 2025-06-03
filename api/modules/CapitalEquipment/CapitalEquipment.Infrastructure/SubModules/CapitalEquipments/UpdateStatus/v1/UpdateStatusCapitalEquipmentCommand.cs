using budget_request_app.WebApi.CapitalEquipment.Domain;
using budget_request_app.WebApi.CapitalEquipment.Infrastructure.SubModules.CapitalEquipments.Create.v1;
using MediatR;

namespace budget_request_app.WebApi.CapitalEquipment.Infrastructure.SubModules.CapitalEquipments.Update.v1;
public sealed record UpdateStatusCapitalEquipmentCommand(
    List<Guid> Ids
    ) : IRequest<UpdateStatusCapitalEquipmentResponse>;
