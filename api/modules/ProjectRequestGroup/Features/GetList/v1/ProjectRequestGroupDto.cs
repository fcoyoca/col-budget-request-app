namespace budget_request_app.WebApi.ProjectRequestGroup.Features.GetList.v1;
public record ProjectRequestGroupDto(
        Guid Id,
        string SubId,
        string BudgetId,
        string GroupTitle,
        int GroupSortOrder,
        string GroupAbbreviation,
        string GroupColor,
        bool IncludeGroupFundingBreakdownGraph,
        bool IncludeGroupFundingBreakdownTable,
        bool IncludeGroupExpenditureBreakdownGraph,
        bool IncludeGroupExpenditureBreakdownTable,
        bool IsEquipmentGroup,
        Guid LookupValueId
    );
