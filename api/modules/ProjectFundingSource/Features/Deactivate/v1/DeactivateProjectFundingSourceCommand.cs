using MediatR;

namespace budget_request_app.WebApi.ProjectFundingSource.Features.Deactivate.v1;
public sealed record DeactivateProjectFundingSourceCommand(
    Guid Id): IRequest<DeactivateProjectFundingSourceResponse>;



