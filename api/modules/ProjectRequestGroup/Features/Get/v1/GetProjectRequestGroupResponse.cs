namespace budget_request_app.WebApi.ProjectRequestGroup.Features.Get.v1;
public record GetProjectRequestGroupResponse(
        Guid id,
        string subId,
        string budgetId,
        string groupTitle,
        int groupSortOrder,
        string groupAbbreviation,
        string groupColor,
        bool includeGroupFundingBreakdownGraph,
        bool includeGroupFundingBreakdownTable,
        bool includeGroupExpenditureBreakdownGraph,
        bool includeGroupExpenditureBreakdownTable,
        bool isEquipmentGroup,
        Guid lookupValueId
    );
