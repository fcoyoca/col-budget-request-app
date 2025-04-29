using budget_request_app.WebApi.CapitalProject.Domain;
using budget_request_app.WebApi.CapitalProject.Infrastructure.SubModules.CapitalProjects.Get.v1.DTOS;
using budget_request_app.WebApi.FileService.Domain;
//using budget_request_app.WebApi.CapitalProject.Infrastructure.SubModules.CapitalProjects.Create.v1;
using budget_request_app.WebApi.LookupValue.Domain;
using Mapster;

namespace budget_request_app.WebApi.CapitalProject.Infrastructure.SubModules.CapitalProjects.Get.v1;

public static class CapitalProjectMapper
{
    public static GetCapitalProjectResponse GetResponse(CapitalProjectItem capitalProjectItem, List<LookupValueItem> lookupValues, List<FundingYearItem> fundingYearItems, List<FileServiceItem> fileServiceItems)
    {
        
        TimeJustificationApprovalDTO timeJustificationApproval = new()
        {
            JustificationPrioritization = capitalProjectItem.JustificationPrioritization.Adapt<JustificationPrioritizationDTO>(),
            GrantFundingOpportunity = capitalProjectItem.GrantFundingOpportunity.Adapt<GrantFundingOpportunityDTO>(),
            ApprovalOversight = capitalProjectItem.ApprovalOversight.Adapt<ApprovalOversightDTO>(),
            StatusTimeline = capitalProjectItem.StatusTimeline.Adapt<StatusTimelineDTO>(),
        };
        
        OperatingBudgetImpactDTO operatingBudgetImpact = new()
        {
            OperatingRevenues = capitalProjectItem.OperatingRevenues.Adapt<List<OperatingRevenueDTO>>(),
            OperatingCosts = capitalProjectItem.OperatingCosts.Adapt<List<OperatingCostDTO>>()
        };
        
        MinorProjectLocationDTO minorProjectLocation = new()
        {
            MinorProjects = capitalProjectItem.MinorProjects.Adapt<List<MinorProjectDTO>>(),
            RequestLocation = new()
            {
                IsMappedRequest = capitalProjectItem.IsMappedRequest,
                GISMappingDescription = capitalProjectItem.GISMappingDescription,
            },
            StreetSegments = capitalProjectItem.StreetSegments.Adapt<List<StreetSegmentDTO>>(),
        };

        FinancialDTO financial = new();
        
        financial.Funding = new()
        {
            TIFFundingIds = capitalProjectItem.TIFFundingIds,
            BorrowingFundings = capitalProjectItem.BorrowingFundings.Adapt<List<BorrowingFundingDTO>>(),
            OperatingFundings = capitalProjectItem.OperatingFundings.Adapt<List<OperatingFundingDTO>>(),
            GrantFundings = capitalProjectItem.GrantFundings.Adapt<List<GrantFundingDTO>>(),
            DonationFunding = new()
            {
                DonationFundingIsContributeFundsRequired = capitalProjectItem.DonationFundingIsContributeFundsRequired,
                DonationFundingIsDonatedFundsUsed = capitalProjectItem.DonationFundingIsDonatedFundsUsed,
                DonationFundings = capitalProjectItem.DonationFundings.Adapt<List<DonationFundingDTO>>()
            },
            SpecialFundings = capitalProjectItem.SpecialFundings.Adapt<List<SpecialFundingDTO>>(),
            OtherFundings = capitalProjectItem.OtherFundings.Adapt<List<OtherFundingDTO>>(),
        };
        
        
        
        financial.Spending = new()
        {
            SpendingBudgets = capitalProjectItem.SpendingBudgets.Adapt<List<SpendingBudgetDTO>>(),
        };

        financial.Change = new()
        {
            FundingChanges = capitalProjectItem.FundingChanges.Adapt<List<FundingChangeDTO>>(),
        };
        
        financial.Past = new()
        {
            PastFundings = capitalProjectItem.PastFundings.Adapt<List<PastFundingDTO>>(),
            PastSpendings = capitalProjectItem.PastSpendings.Adapt<List<PastSpendingDTO>>(),
        };
        
        var attachments = new List<ProjectAttachmentDTO>();

        if (!string.IsNullOrEmpty(capitalProjectItem.FileIds))
        {
            var attachmentIds = capitalProjectItem.FileIds?.Trim().Split(",");
            
            if (attachmentIds.Any())
            {
                 var guids = attachmentIds.Where(x => x != string.Empty).Select(Guid.Parse);
                 attachments = fileServiceItems.Where(x => guids.Contains(x.Id)).Adapt<List<ProjectAttachmentDTO>>();
                
                 foreach (var attachment in attachments)
                 {
                     attachment.Type = Path.GetExtension(attachment.FileName);
                 } 
            }
        }

        return new GetCapitalProjectResponse(
            capitalProjectItem.Id,
            capitalProjectItem.BudgetId,
            capitalProjectItem.RevisionTitle,
            capitalProjectItem.GeneralInformation.Adapt<GeneralInformationDTO>(),
            timeJustificationApproval,
            operatingBudgetImpact,
            minorProjectLocation,
            financial,
            capitalProjectItem.ProjectManagement.Adapt<ProjectManagementDTO>(),
            attachments
            );
    }
}
