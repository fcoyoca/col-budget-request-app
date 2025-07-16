using MediatR;

namespace budget_request_app.WebApi.EquipmentFundingSource.Features.Activate.v1;
public sealed record ActivateEquipmentFundingSourceCommand(
    Guid? Id): IRequest<ActivateEquipmentFundingSourceResponse>;



