using FSH.Framework.Core.Domain.Events;

namespace budget_request_app.WebApi.Catalog.Domain.Events;
public sealed record ProductUpdated : DomainEvent
{
    public Product? Product { get; set; }
}
