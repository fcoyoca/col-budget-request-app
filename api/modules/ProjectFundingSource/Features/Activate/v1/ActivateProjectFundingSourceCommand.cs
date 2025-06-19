using MediatR;

namespace budget_request_app.WebApi.ProjectFundingSource.Features.Activate.v1;
public sealed record ActivateProjectFundingSourceCommand(
    Guid? Id): IRequest<ActivateProjectFundingSourceResponse>;



