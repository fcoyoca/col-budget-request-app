using budget_request_app.WebApi.CapitalEquipment.Domain;
using budget_request_app.WebApi.CapitalEquipment.Infrastructure.SubModules.CapitalEquipments.Create.v1;
using MediatR;

namespace budget_request_app.WebApi.CapitalEquipment.Infrastructure.SubModules.CapitalEquipments.GetProjectNumber.v1;
public sealed record GetProjectNumberCapitalEquipmentRequest(
    ) : IRequest<GetProjectNumberCapitalEquipmentResponse>;
