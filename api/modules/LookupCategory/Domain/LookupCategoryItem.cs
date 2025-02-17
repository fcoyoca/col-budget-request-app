using FSH.Framework.Core.Domain;
using FSH.Framework.Core.Domain.Contracts;
using budget_request_app.WebApi.LookupCategory.Domain.Events;

namespace budget_request_app.WebApi.LookupCategory.Domain;
public class LookupCategoryItem : AuditableEntity, IAggregateRoot
{
    public string? Name { get; set; }

    public string? Description { get; set; }
    public int? ModuleId { get; set; }
    
    public static LookupCategoryItem Create(string name, string description, int? moduleId)
    {
        var item = new LookupCategoryItem();

        item.Name = name;
        item.Description = description;
        item.ModuleId = moduleId.GetValueOrDefault();

        item.QueueDomainEvent(new LookupCategoryItemCreated(item.Id, item.Name, item.Description, item.ModuleId.GetValueOrDefault()));

        return item;
    }

    public LookupCategoryItem Update(string? name, string? description)
    {
        if (name is not null && name?.Equals(name, StringComparison.OrdinalIgnoreCase) is not true) Name = name;
        if (name is not null && name?.Equals(name, StringComparison.OrdinalIgnoreCase) is not true) Name = name;

        this.QueueDomainEvent(new LookupCategoryItemUpdated(this));

        return this;

    }
}
