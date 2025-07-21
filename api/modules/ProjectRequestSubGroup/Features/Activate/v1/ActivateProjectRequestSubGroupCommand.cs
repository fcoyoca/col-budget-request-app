using MediatR;

namespace budget_request_app.WebApi.ProjectRequestSubGroup.Features.Activate.v1;
public sealed record ActivateProjectRequestSubGroupCommand(
    Guid? Id): IRequest<ActivateProjectRequestSubGroupResponse>;
