using FSH.Framework.Core.Domain;
using FSH.Framework.Core.Domain.Contracts;
using budget_request_app.WebApi.ProjectBudgetIntroSectionOutlineItem.Domain.Events;

namespace budget_request_app.WebApi.ProjectBudgetIntroSectionOutlineItem.Domain;

public class ProjectBudgetIntroSectionOutlineItemItem : AuditableEntity, IAggregateRoot
{
    public string? BudgetId { get; set; } = default!;
    public string SectionTitle { get; set; } = default!;
    public int SortOrder { get; set; } = default!;
    public int PageNumberOffset { get; set; } = default!;
    public bool IsActive { get; set; }
    public Guid LookupValueId { get; set; }

    public static ProjectBudgetIntroSectionOutlineItemItem Create(
        string budgetId,
        string sectionTitle,
        int sortOrder,
        int pageNumberOffset,
        Guid lookupValueId)
    {
        var item = new ProjectBudgetIntroSectionOutlineItemItem
        {
            BudgetId = budgetId,
            SectionTitle = sectionTitle,
            SortOrder = sortOrder,
            PageNumberOffset = pageNumberOffset,
            LookupValueId = lookupValueId
        };

        item.QueueDomainEvent(new ProjectBudgetIntroSectionOutlineItemItemCreated(item.Id));

        return item;
    }

    public ProjectBudgetIntroSectionOutlineItemItem Update(
        string? sectionTitle = null,
        int? sortOrder = null,
        int? pageNumberOffset = null)
    {
        if (sectionTitle is not null) SectionTitle = sectionTitle;
        if (sortOrder is not null) SortOrder = sortOrder.Value;
        if (pageNumberOffset is not null) PageNumberOffset = pageNumberOffset.Value;

        QueueDomainEvent(new ProjectBudgetIntroSectionOutlineItemItemUpdated(this));
        return this;
    }
}
