using System.ComponentModel;
using MediatR;

namespace budget_request_app.WebApi.ProjectRequestSubGroup.Features.Create.v1;
public record CreateProjectRequestSubGroupCommand(
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
    ) : IRequest<CreateProjectRequestSubGroupResponse>;
