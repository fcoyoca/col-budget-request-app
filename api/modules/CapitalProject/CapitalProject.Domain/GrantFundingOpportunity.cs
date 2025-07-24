using FSH.Framework.Core.Domain;
using FSH.Framework.Core.Domain.Contracts;
using budget_request_app.WebApi.CapitalProject.Domain.Events;
using System.ComponentModel.DataAnnotations;

namespace budget_request_app.WebApi.CapitalProject.Domain;

public class GrantFundingOpportunity : AuditableEntity, IAggregateRoot
{
    [StringLength(600)]
    public string? GrantFundingOpportunities { get; set; }
    public decimal? TimeSpentReviewingGrantFunding { get; set; }
    public bool? WasCongressionallyDirectedSpendingRequestMade { get; set; } = false;
    [StringLength(250)]
    public string? CongressionallyDirectedSpendingRequestOffice { get; set; }
}
