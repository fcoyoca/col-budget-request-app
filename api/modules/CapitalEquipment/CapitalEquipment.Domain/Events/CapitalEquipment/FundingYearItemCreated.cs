using FSH.Framework.Core.Domain.Events;

namespace budget_request_app.WebApi.CapitalEquipment.Domain.Events;
public sealed record FundingYearItemCreated : DomainEvent
{
    public FundingYearItem? FundingYearItem { get; set; }
}
