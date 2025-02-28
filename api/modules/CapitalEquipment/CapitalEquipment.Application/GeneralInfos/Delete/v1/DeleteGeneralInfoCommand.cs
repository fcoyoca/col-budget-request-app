using MediatR;

namespace budget_request_app.WebApi.CapitalEquipment.Application.GeneralInfos.Delete.v1;
public sealed record DeleteGeneralInfoCommand(
    Guid Id) : IRequest;
