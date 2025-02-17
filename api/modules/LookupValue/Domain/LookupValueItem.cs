using FSH.Framework.Core.Domain;
using FSH.Framework.Core.Domain.Contracts;
using budget_request_app.WebApi.LookupValue.Domain.Events;

namespace budget_request_app.WebApi.LookupValue.Domain;
public class LookupValueItem : AuditableEntity, IAggregateRoot
{
    public string? Name { get; set; }
    public Guid? LookupCategoryId { get; set; }
    public bool? IsActive { get; set; }
    public static LookupValueItem Create(string name, Guid lookupCategoryId)
    {
        var item = new LookupValueItem();

        item.Name = name;
        item.LookupCategoryId = lookupCategoryId;
        item.IsActive = true;

        item.QueueDomainEvent(new LookupValueItemCreated(item.Id, item.Name, item.LookupCategoryId, item.IsActive));

        return item;
    }

    public LookupValueItem Update(string? name)
    {
        if (name is not null && name?.Equals(name, StringComparison.OrdinalIgnoreCase) is not true) Name = name;
        if (name is not null && name?.Equals(name, StringComparison.OrdinalIgnoreCase) is not true) Name = name;

        this.QueueDomainEvent(new LookupValueItemUpdated(this));

        return this;

    }
}
