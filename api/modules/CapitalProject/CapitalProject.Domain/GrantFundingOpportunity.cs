using FSH.Framework.Core.Domain;
using FSH.Framework.Core.Domain.Contracts;
using budget_request_app.WebApi.CapitalProject.Domain.Events;

namespace budget_request_app.WebApi.CapitalProject.Domain;

public class GrantFundingOpportunity : AuditableEntity, IAggregateRoot
{
    public string? GrantFundingOpportunities { get; set; }
    public decimal? TimeSpentReviewingGrantFunding { get; set; }
    public bool? WasCongressionallyDirectedSpendingRequestMade { get; set; } = false;
    public string? CongressionallyDirectedSpendingRequestOffice { get; set; }
}
