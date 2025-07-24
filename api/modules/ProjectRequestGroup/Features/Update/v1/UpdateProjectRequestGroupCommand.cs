using MediatR;

namespace budget_request_app.WebApi.ProjectRequestGroup.Features.Update.v1;
public sealed record UpdateProjectRequestGroupCommand(
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
        Guid LookupValueId) : IRequest<UpdateProjectRequestGroupResponse>;
