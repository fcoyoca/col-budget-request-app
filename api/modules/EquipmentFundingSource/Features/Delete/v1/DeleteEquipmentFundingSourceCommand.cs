using MediatR;

namespace budget_request_app.WebApi.EquipmentFundingSource.Features.Delete.v1;
public sealed record DeleteEquipmentFundingSourceCommand(
    Guid Id) : IRequest;



