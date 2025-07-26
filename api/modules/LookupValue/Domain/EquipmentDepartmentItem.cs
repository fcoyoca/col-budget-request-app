using budget_request_app.WebApi.LookupValue.Domain.Events;
using FSH.Framework.Core.Domain;
using FSH.Framework.Core.Domain.Contracts;

namespace budget_request_app.WebApi.LookupValue.Domain;

public class EquipmentDepartmentItem : AuditableEntity, IAggregateRoot
{
    public string? BudgetId { get; set; } = default!;
    public string SubId { get; set; } = default!;
    public string Title { get; set; } = default!;
    public string Abbreviation { get; set; } = default!;
    public string Color { get; set; } = default!;
    public string FundingCategory { get; set; } = default!;
    public bool IsActive { get; set; }
    public Guid LookupValueId { get; set; }

    public static EquipmentDepartmentItem Create(
        string budgetId,
        string subId,
        string title,
        string abbreviation,
        string color,
        string fundingCategory,
        Guid lookupValueId)
    {
        var item = new EquipmentDepartmentItem
        {
            BudgetId = budgetId,
            SubId = subId,
            Title = title,
            Abbreviation = abbreviation,
            Color = color,
            FundingCategory = fundingCategory,
            LookupValueId = lookupValueId
        };

        item.QueueDomainEvent(new EquipmentDepartmentItemCreated(item.Id));

        return item;
    }

    public EquipmentDepartmentItem Update(
        string? title = null,
        string? abbreviation = null,
        string? color = null,
        string? fundingCategory = null)
    {
        if (title is not null) Title = title;
        if (abbreviation is not null) Abbreviation = abbreviation;
        if (color is not null) Color = color;
        if (fundingCategory is not null) FundingCategory = fundingCategory;

        QueueDomainEvent(new EquipmentDepartmentItemUpdated(this));
        return this;
    }
}
