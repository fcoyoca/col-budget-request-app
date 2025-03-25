using budget_request_app.WebApi.CapitalProject.Domain;
//using budget_request_app.WebApi.CapitalProject.Infrastructure.SubModules.CapitalProjects.Create.v1;

namespace budget_request_app.WebApi.CapitalProject.Infrastructure.SubModules.CapitalProjects.Get.v1;
public sealed record GetCapitalProjectResponse(
    Guid Id,
    string? BudgetId,
    string? RevisionTitle,
    GeneralInformation? GeneralInformation,
    TimeJustificationApproval? TimeJustificationApproval,
    OperatingBudgetImpact? OperatingBudgetImpact,
    MinorProjectLocation? MinorProjectLocation,
    Financial? Financial,
    ProjectManagement? ProjectManagement
    );

public class TimeJustificationApproval
{
    public JustificationPrioritization? JustificationPrioritization { get; set; } 
    public GrantFundingOpportunity? GrantFundingOpportunity { get; set; }
    public ApprovalOversight? ApprovalOversight { get; set; }
}

public class OperatingBudgetImpact
{
    public List<OperatingCost>? OperatingCosts { get; set; }
    public List<OperatingRevenue>? OperatingRevenues { get; set; }
}

public class MinorProjectLocation
{
    public RequestLocation? RequestLocation { get; set; }
    public List<MinorProject>? MinorProjects { get; set; }
    public List<StreetSegment>? StreetSegments { get; set; }
}

public class RequestLocation
{
    public bool? IsMappedRequest { get; set; } = false;
    public string? GISMappingDescription { get; set; }
}

public class Financial
{
    public Funding? Funding { get; set; }
    public Spending? Spending { get; set; }
    public Change? Change { get; set; }
    public Past? Past { get; set; }
}

public class Funding
{
    public List<BorrowingFunding>? BorrowingFundings { get; set; }
    public List<OperatingFunding>? OperatingFundings { get; set; }
    public List<GrantFunding> GrantFundings { get; set; }
    public DonationFunding? DonationFunding { get; set; }
    public List<SpecialFunding> SpecialFundings { get; set; }
    public List<OtherFunding> OtherFundings { get; set; }
}

public class DonationFunding
{
    public List<DonationFunding> DonationFundings { get; set; }
    public bool? DonationFundingIsContributeFundsRequired { get; set; }
    public bool? DonationFundingIsDonatedFundsUsed { get; set; } = false;
}

public class Spending
{
    public List<SpendingBudget>? SpendingBudgets { get; set; }
}

public class Change
{
    public List<FundingChange>? FundingChanges { get; set; }
}

public class Past
{
    public List<PastFunding>? PastFundings { get; set; }
    public List<PastSpending>? PastSpendings { get; set; }
}
