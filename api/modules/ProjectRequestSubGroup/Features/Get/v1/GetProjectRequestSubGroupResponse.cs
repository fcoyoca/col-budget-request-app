namespace budget_request_app.WebApi.ProjectRequestSubGroup.Features.Get.v1;
public record GetProjectRequestSubGroupResponse(
        Guid id,
        string subId,
        string budgetId,
        string groupId,
        string subGroupTitle,
        int subGroupSortOrder,
        string subGroupAbbreviation,
        string subGroupColor,
        bool includeSubGroupFundingBreakdownGraph,
        bool includeSubGroupFundingBreakdownTable,
        bool includeSubGroupExpenditureBreakdownGraph,
        bool includeSubGroupExpenditureBreakdownTable,
        Guid lookupValueId
    );
