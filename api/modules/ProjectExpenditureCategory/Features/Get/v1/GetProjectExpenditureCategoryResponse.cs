namespace budget_request_app.WebApi.ProjectExpenditureCategory.Features.Get.v1;
public record GetProjectExpenditureCategoryResponse(
        Guid id,
        string subId,
        string category,
        string subCategory,
        string subSubCategory,
        string shortDisplayName,
        string budgetId,
        Guid lookupValueId
    );
