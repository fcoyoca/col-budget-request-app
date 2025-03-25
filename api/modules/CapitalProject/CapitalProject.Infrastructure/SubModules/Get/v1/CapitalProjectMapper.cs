using budget_request_app.WebApi.CapitalProject.Domain;
//using budget_request_app.WebApi.CapitalProject.Infrastructure.SubModules.CapitalProjects.Create.v1;
using budget_request_app.WebApi.LookupValue.Domain;
using Mapster;

namespace budget_request_app.WebApi.CapitalProject.Infrastructure.SubModules.CapitalProjects.Get.v1;

public static class CapitalProjectMapper
{
    public static GetCapitalProjectResponse GetResponse(CapitalProjectItem capitalProjectItem, List<LookupValueItem> lookupValues)
    {
        var requestingDepartmentIds = capitalProjectItem
            .GeneralInformation
            .RequestingDepartmentIds.Split(",")
            .Select(x => x.Trim());
        var requestingDepartments = lookupValues.Where(
            x => requestingDepartmentIds.Contains(x.Id.ToString())
        ).Select(x => x.Name).ToList();
        
        var requestingDepartmentHeadIds = capitalProjectItem
            .GeneralInformation
            .DepartmentHeadRequestorId.Split(",")
            .Select(x => x.Trim());
        
        var requestingDepartmentHeads = lookupValues.Where(
            x => requestingDepartmentHeadIds.Contains(x.Id.ToString())
        ).Select(x => x.Name).ToList();
        
        var requestStatus = lookupValues.FirstOrDefault(x => x.Id.ToString() == capitalProjectItem.GeneralInformation.RequestStatusId);
        var requestStatusName = string.Empty;
        if (requestStatus != null)
        {
            requestStatusName = requestStatus.Name;
        }
        
        TimeJustificationApproval timeJustificationApproval = new TimeJustificationApproval();
        timeJustificationApproval.JustificationPrioritization = capitalProjectItem.JustificationPrioritization;
        timeJustificationApproval.ApprovalOversight = capitalProjectItem.ApprovalOversight;
        timeJustificationApproval.GrantFundingOpportunity = capitalProjectItem.GrantFundingOpportunity;
        
        OperatingBudgetImpact operatingBudgetImpact = new OperatingBudgetImpact();
        operatingBudgetImpact.OperatingRevenues = capitalProjectItem.OperatingRevenues;
        operatingBudgetImpact.OperatingCosts = capitalProjectItem.OperatingCosts;
        
        MinorProjectLocation minorProjectLocation = new MinorProjectLocation();
        minorProjectLocation.MinorProjects = capitalProjectItem.MinorProjects;
        minorProjectLocation.RequestLocation = new()
        {
            IsMappedRequest = capitalProjectItem.IsMappedRequest,
            GISMappingDescription = capitalProjectItem.GISMappingDescription,
        };
        minorProjectLocation.StreetSegments = capitalProjectItem.StreetSegments;
        
        Financial financial = new Financial();
        financial.Funding = new()
        {
            BorrowingFundings = capitalProjectItem.BorrowingFundings,
            OperatingFundings = capitalProjectItem.OperatingFundings,
            GrantFundings = capitalProjectItem.GrantFundings,
            DonationFunding = new DonationFunding()
            {
                DonationFundingIsContributeFundsRequired = capitalProjectItem.DonationFundingIsContributeFundsRequired,
                DonationFundingIsDonatedFundsUsed = capitalProjectItem.DonationFundingIsDonatedFundsUsed,
                DonationFundings = capitalProjectItem.DonationFundings.Adapt<List<DonationFunding>>()
            }
        };
        
        financial.Spending = new Spending()
        {
            SpendingBudgets = capitalProjectItem.SpendingBudgets,
        };
        
        financial.Past = new Past()
        {
            PastFundings = capitalProjectItem.PastFundings,
            PastSpendings = capitalProjectItem.PastSpendings
        };

        return new GetCapitalProjectResponse(
            capitalProjectItem.Id,
            capitalProjectItem.BudgetId,
            capitalProjectItem.RevisionTitle,
            capitalProjectItem.GeneralInformation,
            timeJustificationApproval,
            operatingBudgetImpact,
            minorProjectLocation,
            financial,
            capitalProjectItem.ProjectManagement
            );
    }
}
