using MediatR;

namespace budget_request_app.WebApi.ProjectRequestGroup.Features.Delete.v1;
public sealed record DeleteProjectRequestGroupCommand(
    Guid Id) : IRequest;
