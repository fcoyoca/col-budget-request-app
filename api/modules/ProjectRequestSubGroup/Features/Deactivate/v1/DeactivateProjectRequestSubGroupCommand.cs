using budget_request_app.WebApi.ProjectRequestSubGroup.Features.Activate.v1;
using budget_request_app.WebApi.ProjectRequestSubGroup.Features.Activate.v1;
using MediatR;

namespace budget_request_app.WebApi.ProjectRequestSubGroup.Features.Deactivate.v1;
public sealed record DeactivateProjectRequestSubGroupCommand(
    Guid Id): IRequest<DeactivateProjectRequestSubGroupResponse>;
