using FSH.Framework.Core.Domain;
using FSH.Framework.Core.Domain.Contracts;
using budget_request_app.WebApi.CapitalProject.Domain.Events;

namespace budget_request_app.WebApi.CapitalProject.Domain;
public class CapitalProjectItem : AuditableEntity, IAggregateRoot
{
    public string? BudgetId { get; set; }
    public string? RevisionTitle { get; set; }
    public int RequestId { get; set; }
    // 1st tab
    public GeneralInformation? GeneralInformation { get; set; }
    // 2nd tab
    public JustificationPrioritization? JustificationPrioritization { get; set; }
    public StatusTimeline? StatusTimeline { get; set; }
    public GrantFundingOpportunity? GrantFundingOpportunity { get; set; }
    public ApprovalOversight? ApprovalOversight { get; set; }
    
    // 3rd tab
    public List<OperatingCost>? OperatingCosts { get; set; }
    public List<OperatingRevenue>? OperatingRevenues { get; set; }
    
    // tab4 - request location
    public bool? IsMappedRequest { get; set; } = false;
    public string? GISMappingDescription { get; set; }
    public List<MinorProject>? MinorProjects { get; set; }
    public List<StreetSegment>? StreetSegments { get; set; }
    
    // financials
    
    // financials - funding
    public string? TIFFundingIds { get; set; }
    public List<BorrowingFunding>? BorrowingFundings { get; set; }
    public List<OperatingFunding>? OperatingFundings { get; set; }
    public List<GrantFunding> GrantFundings { get; set; }
    public List<DonationFunding> DonationFundings { get; set; }
    public bool? DonationFundingIsContributeFundsRequired { get; set; }
    public bool? DonationFundingIsDonatedFundsUsed { get; set; } = false;
    public decimal? AmountAdvanced { get; set; }
    public string? AdvancedFundsDescription { get; set; }
    public decimal? DonatedAmountCollected { get; set; }
    public decimal? AmountDonated { get; set; }
    public string? DonationArrangements { get; set; }
    public List<SpecialFunding> SpecialFundings { get; set; }
    public List<OtherFunding> OtherFundings { get; set; }
    
    // financials - spending
    public List<SpendingBudget>? SpendingBudgets { get; set; }
    
    // financials - change
    public List<FundingChange>? FundingChanges { get; set; }
    
    // financials - past
    public List<PastFunding>? PastFundings { get; set; }
    public List<PastSpending>? PastSpendings { get; set; }
    
    // project management
    public ProjectManagement? ProjectManagement { get; set; }
    public string? FileIds { get; set; }

    public static CapitalProjectItem Create(
        
        )
    {
        var CapitalProject = new CapitalProjectItem();
        
        CapitalProject.QueueDomainEvent(new CapitalProjectCreated() { CapitalProject = CapitalProject });

        return CapitalProject;
    }

    public static CapitalProjectItem Update(

        )
    {
        var CapitalProject = new CapitalProjectItem();
        CapitalProject.QueueDomainEvent(new CapitalProjectUpdated() { CapitalProject = CapitalProject });

        return CapitalProject;
    }
}
