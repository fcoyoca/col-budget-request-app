using budget_request_app.WebApi.CapitalProject.Domain;
using budget_request_app.WebApi.CapitalProject.Infrastructure.SubModules.CapitalProjects.Get.v1.DTOS;

//using budget_request_app.WebApi.CapitalProject.Infrastructure.SubModules.CapitalProjects.Create.v1;

namespace budget_request_app.WebApi.CapitalProject.Infrastructure.SubModules.CapitalProjects.Get.v1;
public sealed record GetCapitalProjectResponse(
    Guid Id,
    string? BudgetId,
    string? RevisionTitle,
    GeneralInformationDTO? GeneralInformation,
    TimeJustificationApprovalDTO? TimeJustificationApproval,
    OperatingBudgetImpactDTO? OperatingBudgetImpact,
    MinorProjectLocationDTO? MinorProjectLocation,
    FinancialDTO? Financial,
    ProjectManagementDTO? ProjectManagement
    );

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
