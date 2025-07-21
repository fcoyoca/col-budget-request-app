using System.ComponentModel;
using MediatR;

namespace budget_request_app.WebApi.ProjectRequestGroup.Features.Create.v1;
public record CreateProjectRequestGroupCommand(
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
    ) : IRequest<CreateProjectRequestGroupResponse>;
