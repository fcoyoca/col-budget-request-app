using budget_request_app.WebApi.ProjectRequestStatus.Features.Activate.v1;
using budget_request_app.WebApi.ProjectRequestStatus.Features.Activate.v1;
using MediatR;

namespace budget_request_app.WebApi.ProjectRequestStatus.Features.Deactivate.v1;
public sealed record DeactivateProjectRequestStatusCommand(
    Guid Id): IRequest<DeactivateProjectRequestStatusResponse>;
