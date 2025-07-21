using MediatR;

namespace budget_request_app.WebApi.ProjectRequestSubGroup.Features.Update.v1;
public sealed record UpdateProjectRequestSubGroupCommand(
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
        Guid LookupValueId) : IRequest<UpdateProjectRequestSubGroupResponse>;
