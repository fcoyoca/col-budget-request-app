namespace budget_request_app.WebApi.ProjectRequestSubGroup.Features.GetList.v1;
public record ProjectRequestSubGroupDto(
        Guid Id,
        string SubId,
        string BudgetId,
        string GroupId,
        string SubGroupTitle,
        int SubGroupSortOrder,
        string SubGroupAbbreviation,
        string SubGroupColor,
        bool IncludeSubGroupFundingBreakdownGraph,
        bool IncludeSubGroupFundingBreakdownTable,
        bool IncludeSubGroupExpenditureBreakdownGraph,
        bool IncludeSubGroupExpenditureBreakdownTable,
        Guid LookupValueId
    );
