namespace budget_request_app.WebApi.ProjectBudgetIntroSectionOutlineItem.Features.GetList.v1;
public record ProjectBudgetIntroSectionOutlineItemDto(
        Guid Id,
        string BudgetId,
        string SectionTitle,
        int SortOrder,
        int PageNumberOffset,
        Guid LookupValueId
    );
