using MediatR;

namespace budget_request_app.WebApi.ProjectFundingSource.Features.Delete.v1;
public sealed record DeleteProjectFundingSourceCommand(
    Guid Id) : IRequest;



