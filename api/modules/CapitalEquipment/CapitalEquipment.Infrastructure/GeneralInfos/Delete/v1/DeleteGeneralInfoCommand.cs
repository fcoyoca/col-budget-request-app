using MediatR;

namespace budget_request_app.WebApi.CapitalEquipment.Infrastructure.GeneralInfos.Delete.v1;
public sealed record DeleteGeneralInfoCommand(
    Guid Id) : IRequest;
