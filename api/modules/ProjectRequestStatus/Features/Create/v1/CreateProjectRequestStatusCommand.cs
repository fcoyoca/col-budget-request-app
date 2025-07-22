using System.ComponentModel;
using budget_request_app.WebApi.ProjectRequestStatus.Features.Create.v1;
using MediatR;

namespace budget_request_app.WebApi.ProjectRequestStatus.Features.Create.v1;
public record CreateProjectRequestStatusCommand(
        string BudgetId,
        string SubId,
        string Title,
        bool IsUnfundedStatus,
        Guid LookupValueId
    ) : IRequest<CreateProjectRequestStatusResponse>;
