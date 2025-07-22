using MediatR;

namespace budget_request_app.WebApi.ProjectRequestStatus.Features.Update.v1;
public sealed record UpdateProjectRequestStatusCommand(
        Guid Id,
        string BudgetId,
        string SubId,
        string Title,
        bool IsUnfundedStatus,
        Guid LookupValueId) : IRequest<UpdateProjectRequestStatusResponse>;
