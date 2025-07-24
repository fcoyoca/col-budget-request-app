using budget_request_app.WebApi.ProjectRequestStatus.Features.Activate.v1;
using MediatR;

namespace budget_request_app.WebApi.ProjectRequestStatus.Features.Activate.v1;
public sealed record ActivateProjectRequestStatusCommand(
    Guid? Id): IRequest<ActivateProjectRequestStatusResponse>;
