using FSH.Framework.Core.Domain;
using FSH.Framework.Core.Domain.Contracts;
using budget_request_app.WebApi.ProjectRequestGroup.Domain.Events;

namespace budget_request_app.WebApi.ProjectRequestGroup.Domain;

public class ProjectRequestGroupItem : AuditableEntity, IAggregateRoot
{
    public string SubId { get; set; } = default!;
    public string? BudgetId { get; set; } = default!;
    public string GroupTitle { get; set; } = default!;
    public int GroupSortOrder { get; set; } = default!;
    public string GroupAbbreviation { get; set; } = default!;
    public string GroupColor { get; set; } = default!;
    public bool IncludeGroupFundingBreakdownGraph { get; set; }
    public bool IncludeGroupFundingBreakdownTable { get; set; }
    public bool IncludeGroupExpenditureBreakdownGraph { get; set; }
    public bool IncludeGroupExpenditureBreakdownTable { get; set; }
    public bool IsEquipmentGroup { get; set; }
    public bool IsActive { get; set; }
    public Guid LookupValueId { get; set; }

    public static ProjectRequestGroupItem Create(
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
        Guid lookupValueId)
    {
        var item = new ProjectRequestGroupItem
        {
            SubId = subId,
            BudgetId = budgetId,
            GroupTitle = groupTitle,
            GroupSortOrder = groupSortOrder,
            GroupAbbreviation = groupAbbreviation,
            GroupColor = groupColor,
            IncludeGroupFundingBreakdownGraph = includeGroupFundingBreakdownGraph,
            IncludeGroupFundingBreakdownTable = includeGroupFundingBreakdownTable,
            IncludeGroupExpenditureBreakdownGraph = includeGroupExpenditureBreakdownGraph,
            IncludeGroupExpenditureBreakdownTable = includeGroupExpenditureBreakdownTable,
            IsEquipmentGroup = isEquipmentGroup,
            LookupValueId = lookupValueId
        };

        item.QueueDomainEvent(new ProjectRequestGroupItemCreated(item.Id));

        return item;
    }

    public ProjectRequestGroupItem Update(
        string? groupTitle = null,
        int? groupSortOrder = null,
        string? groupAbbreviation = null,
        string? groupColor = null,
        bool? includeGroupFundingBreakdownGraph = null,
        bool? includeGroupFundingBreakdownTable = null,
        bool? includeGroupExpenditureBreakdownGraph = null,
        bool? includeGroupExpenditureBreakdownTable = null,
        bool? isEquipmentGroup = null)
    {
        if (groupTitle is not null) GroupTitle = groupTitle;
        if (groupSortOrder is not null) GroupSortOrder = groupSortOrder.Value;
        if (groupAbbreviation is not null) GroupAbbreviation = groupAbbreviation;
        if (groupColor is not null) GroupColor = groupColor;
        if (includeGroupFundingBreakdownGraph is not null) IncludeGroupFundingBreakdownGraph = includeGroupFundingBreakdownGraph.Value;
        if (includeGroupFundingBreakdownTable is not null) IncludeGroupFundingBreakdownTable = includeGroupFundingBreakdownTable.Value;
        if (includeGroupExpenditureBreakdownGraph is not null) IncludeGroupExpenditureBreakdownGraph = includeGroupExpenditureBreakdownGraph.Value;
        if (includeGroupExpenditureBreakdownTable is not null) IncludeGroupExpenditureBreakdownTable = includeGroupExpenditureBreakdownTable.Value;
        if (isEquipmentGroup is not null) IsEquipmentGroup = isEquipmentGroup.Value;

        QueueDomainEvent(new ProjectRequestGroupItemUpdated(this));
        return this;
    }
}
