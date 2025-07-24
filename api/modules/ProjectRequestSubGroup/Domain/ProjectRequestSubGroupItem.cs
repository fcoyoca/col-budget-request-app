using FSH.Framework.Core.Domain;
using FSH.Framework.Core.Domain.Contracts;
using budget_request_app.WebApi.ProjectRequestSubGroup.Domain.Events;

namespace budget_request_app.WebApi.ProjectRequestSubGroup.Domain;

public class ProjectRequestSubGroupItem : AuditableEntity, IAggregateRoot
{
    public string SubId { get; set; } = default!;
    public string? BudgetId { get; set; } = default!;
    public string GroupId { get; set; } = default!;
    public string SubGroupTitle { get; set; } = default!;
    public int SubGroupSortOrder { get; set; } = default!;
    public string SubGroupAbbreviation { get; set; } = default!;
    public string SubGroupColor { get; set; } = default!;
    public bool IncludeSubGroupFundingBreakdownGraph { get; set; }
    public bool IncludeSubGroupFundingBreakdownTable { get; set; }
    public bool IncludeSubGroupExpenditureBreakdownGraph { get; set; }
    public bool IncludeSubGroupExpenditureBreakdownTable { get; set; }
    public bool IsActive { get; set; }
    public Guid LookupValueId { get; set; }

    public static ProjectRequestSubGroupItem Create(
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
        Guid lookupValueId)
    {
        var item = new ProjectRequestSubGroupItem
        {
            SubId = subId,
            BudgetId = budgetId,
            GroupId = groupId,
            SubGroupTitle = subGroupTitle,
            SubGroupSortOrder = subGroupSortOrder,
            SubGroupAbbreviation = subGroupAbbreviation,
            SubGroupColor = subGroupColor,
            IncludeSubGroupFundingBreakdownGraph = includeSubGroupFundingBreakdownGraph,
            IncludeSubGroupFundingBreakdownTable = includeSubGroupFundingBreakdownTable,
            IncludeSubGroupExpenditureBreakdownGraph = includeSubGroupExpenditureBreakdownGraph,
            IncludeSubGroupExpenditureBreakdownTable = includeSubGroupExpenditureBreakdownTable,
            LookupValueId = lookupValueId
        };

        item.QueueDomainEvent(new ProjectRequestSubGroupItemCreated(item.Id));

        return item;
    }

    public ProjectRequestSubGroupItem Update(
        string groupId = null,
        string? subGroupTitle = null,
        int? subGroupSortOrder = null,
        string? subGroupAbbreviation = null,
        string? subGroupColor = null,
        bool? includeSubGroupFundingBreakdownGraph = null,
        bool? includeSubGroupFundingBreakdownTable = null,
        bool? includeSubGroupExpenditureBreakdownGraph = null,
        bool? includeSubGroupExpenditureBreakdownTable = null)
    {
        if (groupId is not null) GroupId = groupId;
        if (subGroupTitle is not null) SubGroupTitle = subGroupTitle;
        if (subGroupSortOrder is not null) SubGroupSortOrder = subGroupSortOrder.Value;
        if (subGroupAbbreviation is not null) SubGroupAbbreviation = subGroupAbbreviation;
        if (subGroupColor is not null) SubGroupColor = subGroupColor;
        if (includeSubGroupFundingBreakdownGraph is not null) IncludeSubGroupFundingBreakdownGraph = includeSubGroupFundingBreakdownGraph.Value;
        if (includeSubGroupFundingBreakdownTable is not null) IncludeSubGroupFundingBreakdownTable = includeSubGroupFundingBreakdownTable.Value;
        if (includeSubGroupExpenditureBreakdownGraph is not null) IncludeSubGroupExpenditureBreakdownGraph = includeSubGroupExpenditureBreakdownGraph.Value;
        if (includeSubGroupExpenditureBreakdownTable is not null) IncludeSubGroupExpenditureBreakdownTable = includeSubGroupExpenditureBreakdownTable.Value;

        QueueDomainEvent(new ProjectRequestSubGroupItemUpdated(this));
        return this;
    }
}
