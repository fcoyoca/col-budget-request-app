using MediatR;

namespace budget_request_app.WebApi.ProjectRequestSubGroup.Features.Delete.v1;
public sealed record DeleteProjectRequestSubGroupCommand(
    Guid Id) : IRequest;
