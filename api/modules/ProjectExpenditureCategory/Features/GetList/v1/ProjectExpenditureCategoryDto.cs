namespace budget_request_app.WebApi.ProjectExpenditureCategory.Features.GetList.v1;
public record ProjectExpenditureCategoryDto(
    Guid Id,
    string SubId,
    string Category,
    string SubCategory,
    string SubSubCategory,
    string ShortDisplayName,
    string BudgetId,
    Guid LookupValueId
    );
