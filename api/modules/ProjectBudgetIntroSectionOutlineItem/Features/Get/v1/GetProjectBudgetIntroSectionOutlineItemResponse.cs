namespace budget_request_app.WebApi.ProjectBudgetIntroSectionOutlineItem.Features.Get.v1;
public record GetProjectBudgetIntroSectionOutlineItemResponse(
        Guid id,
        string budgetId,
        string sectionTitle,
        int sortOrder,
        int pageNumberOffset,
        Guid lookupValueId
    );
