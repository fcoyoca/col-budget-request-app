namespace budget_request_app.WebApi.ProjectRequestStatus.Features.GetList.v1;
public record ProjectRequestStatusDto(
        Guid Id,
        string BudgetId,
        string SubId,
        string Title,
        bool IsUnfundedStatus,
        Guid LookupValueId
    );
