using budget_request_app.WebApi.ProjectRequestGroup.Features.Activate.v1;
using budget_request_app.WebApi.ProjectRequestGroup.Features.Activate.v1;
using MediatR;

namespace budget_request_app.WebApi.ProjectRequestGroup.Features.Deactivate.v1;
public sealed record DeactivateProjectRequestGroupCommand(
    Guid Id): IRequest<DeactivateProjectRequestGroupResponse>;
