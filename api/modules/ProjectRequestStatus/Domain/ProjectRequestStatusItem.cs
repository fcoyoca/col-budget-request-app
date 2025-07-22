using FSH.Framework.Core.Domain;
using FSH.Framework.Core.Domain.Contracts;
using budget_request_app.WebApi.ProjectRequestStatus.Domain.Events;

namespace budget_request_app.WebApi.ProjectRequestStatus.Domain;

public class ProjectRequestStatusItem : AuditableEntity, IAggregateRoot
{
    public string? BudgetId { get; set; } = default!;
    public string SubId { get; set; } = default!;
    public string Title { get; set; } = default!;
    public bool IsUnfundedStatus { get; set; }
    public bool IsActive { get; set; }
    public Guid LookupValueId { get; set; }

    public static ProjectRequestStatusItem Create(
        string budgetId,
        string subId,
        string title,
        bool isUnfundedStatus,
        Guid lookupValueId)
    {
        var item = new ProjectRequestStatusItem
        {
            BudgetId = budgetId,
            SubId = subId,
            Title = title,
            IsUnfundedStatus = isUnfundedStatus,
            LookupValueId = lookupValueId
        };

        item.QueueDomainEvent(new ProjectRequestStatusItemCreated(item.Id));

        return item;
    }

    public ProjectRequestStatusItem Update(
        string? title = null,
        bool? isUnfundedStatus = null)
    {
        if (title is not null) Title = title;
        if (isUnfundedStatus is not null) IsUnfundedStatus = isUnfundedStatus.Value;

        QueueDomainEvent(new ProjectRequestStatusItemUpdated(this));
        return this;
    }
}
