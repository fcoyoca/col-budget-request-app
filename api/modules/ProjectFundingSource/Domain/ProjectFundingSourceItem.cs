using FSH.Framework.Core.Domain;
using FSH.Framework.Core.Domain.Contracts;
using budget_request_app.WebApi.ProjectFundingSource.Domain.Events;

namespace budget_request_app.WebApi.ProjectFundingSource.Domain;

public class ProjectFundingSourceItem : AuditableEntity, IAggregateRoot
{
    public string SubId { get; set; } = default!;
    public string SubSubId { get; set; } = default!;
    public string Source { get; set; } = default!;
    public string SubSource { get; set; } = default!;
    public string SubSubSource { get; set; } = default!;
    public string DisplayName { get; set; } = default!;
    public string DisplayTitle { get; set; } = default!;
    public string DisplaySubTitle { get; set; } = default!;
    public string ChartDisplayName { get; set; } = default!;
    public bool IsCityFunded { get; set; }
    public bool IsNewBorrowing { get; set; }
    public string? BudgetId { get; set; } = default!;
    public bool IsGrantFunding { get; set; }
    public bool IsOutsideFunding { get; set; }
    public bool IsTifIncrementFunding { get; set; }
    
    public bool IsActive { get; set; }
    public Guid LookupValueId { get; set; }

    public static ProjectFundingSourceItem Create(
        string subId,
        string subSubId,
        string source,
        string subSource,
        string subSubSource,
        string displayName,
        string displayTitle,
        string displaySubTitle,
        string chartDisplayName,
        bool isCityFunded,
        bool isNewBorrowing,
        string budgetId,
        bool isGrantFunding,
        bool isOutsideFunding,
        bool isTifIncrementFunding,
        Guid lookupValueId)
    {
        var item = new ProjectFundingSourceItem
        {
            SubId = subId,
            SubSubId = subSubId,
            Source = source,
            SubSource = subSource,
            SubSubSource = subSubSource,
            DisplayName = displayName,
            DisplayTitle = displayTitle,
            DisplaySubTitle = displaySubTitle,
            ChartDisplayName = chartDisplayName,
            IsCityFunded = isCityFunded,
            IsNewBorrowing = isNewBorrowing,
            BudgetId = budgetId,
            IsGrantFunding = isGrantFunding,
            IsOutsideFunding = isOutsideFunding,
            IsTifIncrementFunding = isTifIncrementFunding,
            LookupValueId = lookupValueId
        };

        item.QueueDomainEvent(new ProjectFundingSourceItemCreated(item.Id));

        return item;
    }

    public ProjectFundingSourceItem Update(
        string? displayName = null,
        string? displayTitle = null,
        string? displaySubTitle = null,
        string? chartDisplayName = null)
    {
        if (displayName is not null) DisplayName = displayName;
        if (displayTitle is not null) DisplayTitle = displayTitle;
        if (displaySubTitle is not null) DisplaySubTitle = displaySubTitle;
        if (chartDisplayName is not null) ChartDisplayName = chartDisplayName;

        QueueDomainEvent(new ProjectFundingSourceItemUpdated(this));
        return this;
    }
}
