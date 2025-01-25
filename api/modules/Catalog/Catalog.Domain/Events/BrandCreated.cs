using FSH.Framework.Core.Domain.Events;

namespace budget_request_app.WebApi.Catalog.Domain.Events;
public sealed record BrandCreated : DomainEvent
{
    public Brand? Brand { get; set; }
}
