using MediatR;

namespace budget_request_app.WebApi.ProjectRequestGroup.Features.Activate.v1;
public sealed record ActivateProjectRequestGroupCommand(
    Guid? Id): IRequest<ActivateProjectRequestGroupResponse>;
