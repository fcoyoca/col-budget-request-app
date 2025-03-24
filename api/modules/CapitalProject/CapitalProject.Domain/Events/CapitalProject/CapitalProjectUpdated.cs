using FSH.Framework.Core.Domain.Events;

namespace budget_request_app.WebApi.CapitalProject.Domain.Events;
public sealed record CapitalProjectUpdated : DomainEvent
{
    public CapitalProjectItem? CapitalProject { get; set; }
}
