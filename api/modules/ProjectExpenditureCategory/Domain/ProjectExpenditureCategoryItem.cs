using FSH.Framework.Core.Domain;
using FSH.Framework.Core.Domain.Contracts;
using budget_request_app.WebApi.ProjectExpenditureCategory.Domain.Events;

namespace budget_request_app.WebApi.ProjectExpenditureCategory.Domain;

public class ProjectExpenditureCategoryItem : AuditableEntity, IAggregateRoot
{
    public string SubId { get; set; } = default!;
    public string Category { get; set; } = default!;
    public string SubCategory { get; set; } = default!;
    public string SubSubCategory { get; set; } = default!;
    public string ShortDisplayName { get; set; } = default!;
    public string? BudgetId { get; set; } = default!;
    public bool IsActive { get; set; }
    public Guid LookupValueId { get; set; }

    public static ProjectExpenditureCategoryItem Create(
        string subId,
        string category,
        string subCategory,
        string subSubCategory,
        string shortDisplayName,
        string budgetId,
        Guid lookupValueId)
    {
        var item = new ProjectExpenditureCategoryItem
        {
            SubId = subId,
            Category = category,
            SubCategory = subCategory,
            SubSubCategory = subSubCategory,
            ShortDisplayName = shortDisplayName,
            BudgetId = budgetId,
            LookupValueId = lookupValueId
        };

        item.QueueDomainEvent(new ProjectExpenditureCategoryItemCreated(item.Id));

        return item;
    }

    public ProjectExpenditureCategoryItem Update(
        string? category = null,
        string? subCategory = null,
        string? subSubCategory = null,
        string? shortDisplayName = null)
    {
        if (category is not null) Category = category;
        if (subCategory is not null) SubCategory = subSubCategory;
        if (subSubCategory is not null) SubSubCategory = subSubCategory;
        if (shortDisplayName is not null) ShortDisplayName = shortDisplayName;

        QueueDomainEvent(new ProjectExpenditureCategoryItemUpdated(this));
        return this;
    }
}
