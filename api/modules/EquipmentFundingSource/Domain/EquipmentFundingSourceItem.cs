using FSH.Framework.Core.Domain;
using FSH.Framework.Core.Domain.Contracts;
using budget_request_app.WebApi.EquipmentFundingSource.Domain.Events;

namespace budget_request_app.WebApi.EquipmentFundingSource.Domain;

public class EquipmentFundingSourceItem : AuditableEntity, IAggregateRoot
{
    public string SubId { get; set; } = default!;
    public string? SpecialCode { get; set; } = default!;
    public string? BudgetId { get; set; } = default!;
    public string Title { get; set; } = default!;
    public string Abbreviation { get; set; } = default!;
    public string Code { get; set; } = default!;
    public int SortOrder { get; set; } = default!;
    public bool IsNewBorrowing { get; set; }
    public string FundingSource { get; set; } = default!;
    public string FundingSubSource { get; set; } = default!;
    public bool IsActive { get; set; }
    public Guid LookupValueId { get; set; }
    public static EquipmentFundingSourceItem Create(
        string subId,
        string specialCode,
        string budgetId,
        string title,
        string abbreviation,
        string code,
        int sortOrder,
        bool isNewBorrowing,
        string fundingSource,
        string fundingSubSource,
        Guid lookupValueId)
    {
        var item = new EquipmentFundingSourceItem
        {
            SubId = subId,
            SpecialCode = specialCode,
            BudgetId = budgetId,
            Title = title,
            Abbreviation = abbreviation,
            Code = code,
            SortOrder = sortOrder,
            IsNewBorrowing = isNewBorrowing,
            FundingSource = fundingSource,
            FundingSubSource = fundingSubSource,
            LookupValueId = lookupValueId
        };

        item.QueueDomainEvent(new EquipmentFundingSourceItemCreated(item.Id));

        return item;
    }

    public EquipmentFundingSourceItem Update(
        string? specialCode = null,
        string? title = null,
        string? fundingSource = null,
        string? fundingSubSource = null)
    {
        if (specialCode is not null) SpecialCode = specialCode;
        if (title is not null) Title = title;
        if (fundingSource is not null) FundingSource = fundingSource;
        if (fundingSubSource is not null) FundingSubSource = fundingSubSource;

        QueueDomainEvent(new EquipmentFundingSourceItemUpdated(this));
        return this;
    }
}
