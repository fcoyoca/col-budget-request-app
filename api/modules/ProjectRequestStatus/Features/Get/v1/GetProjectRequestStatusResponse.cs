namespace budget_request_app.WebApi.ProjectRequestStatus.Features.Get.v1;
public record GetProjectRequestStatusResponse(
        Guid id,
        string budgetId,
        string subId,
        string title,
        bool isUnfundedStatus,
        Guid lookupValueId
    );
