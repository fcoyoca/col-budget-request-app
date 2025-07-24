using MediatR;

namespace budget_request_app.WebApi.ProjectRequestStatus.Features.Delete.v1;
public sealed record DeleteProjectRequestStatusCommand(
    Guid Id) : IRequest;
