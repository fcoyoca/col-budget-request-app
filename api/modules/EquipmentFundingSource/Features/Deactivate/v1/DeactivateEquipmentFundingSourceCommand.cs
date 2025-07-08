using budget_request_app.WebApi.EquipmentFundingSource.Features.Activate.v1;
using MediatR;

namespace budget_request_app.WebApi.EquipmentFundingSource.Features.Deactivate.v1;
public sealed record DeactivateEquipmentFundingSourceCommand(
    Guid Id): IRequest<DeactivateEquipmentFundingSourceResponse>;



