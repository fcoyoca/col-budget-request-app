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
        var approvalOversight = capitalProjectItem.ApprovalOversight.Adapt<ApprovalOversightDTO>();
        approvalOversight.ApprovingOversightBoardValue =
            MapToLookupNames(approvalOversight.ApprovingOversightBoardId.GetValueOrDefault(), lookupValues);
        
        var statusTimeline = capitalProjectItem.StatusTimeline.Adapt<StatusTimelineDTO>();
        statusTimeline.DepartmentPointOfContactValue = MapToLookupNames(statusTimeline.DepartmentPointOfContactId,lookupValues);

        var grantFundingOpportunity = capitalProjectItem.GrantFundingOpportunity.Adapt<GrantFundingOpportunityDTO>();
        grantFundingOpportunity.CongressionallyDirectedSpendingRequestOfficeValue = MapToLookupNames(grantFundingOpportunity.CongressionallyDirectedSpendingRequestOffice,lookupValues);
        
        TimeJustificationApprovalDTO timeJustificationApproval = new()
        {
            JustificationPrioritization = capitalProjectItem.JustificationPrioritization.Adapt<JustificationPrioritizationDTO>(),
            GrantFundingOpportunity = grantFundingOpportunity,
            ApprovalOversight = approvalOversight,
            StatusTimeline = statusTimeline,
        };

        var operatingRevenues = capitalProjectItem.OperatingRevenues.Adapt<List<OperatingRevenueDTO>>();

        foreach (var operatingRevenue in operatingRevenues)
        {
            operatingRevenue.FundingSourceValue = MapToLookupNames(operatingRevenue.FundingSourceId,lookupValues);
            operatingRevenue.DepartmentValue = MapToLookupNames(operatingRevenue.DepartmentId,lookupValues);
        }
        
        var operatingCosts = capitalProjectItem.OperatingCosts.Adapt<List<OperatingCostDTO>>();

        foreach (var operatingCost in operatingCosts)
        {
            operatingCost.FundingSourceValue = MapToLookupNames(operatingCost.FundingSourceId,lookupValues);
            operatingCost.DepartmentValue = MapToLookupNames(operatingCost.DepartmentId,lookupValues);
        }

        OperatingBudgetImpactDTO operatingBudgetImpact = new()
        {
            OperatingRevenues = operatingRevenues,
            OperatingCosts = operatingCosts,
        };

        var minorProjects = capitalProjectItem.MinorProjects.Adapt<List<MinorProjectDTO>>();

        foreach (var minorProject in minorProjects)
        {
            minorProject.ExpenditureCategoryValue = MapToLookupNames(minorProject.ExpenditureCategoryId, lookupValues);
        }
        
        var streetSegments = capitalProjectItem.StreetSegments.Adapt<List<StreetSegmentDTO>>();

        foreach (var streetSegment in streetSegments)
        {
            streetSegment.PavementRatingValue = MapToLookupNames(streetSegment.PavementRating, lookupValues);
            streetSegment.CurbRatingValue = MapToLookupNames(streetSegment.CurbRating, lookupValues);
            streetSegment.PaveValue = MapToLookupNames(streetSegment.Pave, lookupValues);
            streetSegment.RightOfWayValue = MapToLookupNames(streetSegment.RightOfWay, lookupValues);
            streetSegment.SafetyImprovementsValue = MapToLookupNames(streetSegment.SafetyImprovements, lookupValues);
            streetSegment.UtilityWorkValue = MapToLookupNames(streetSegment.UtilityWork, lookupValues);
            streetSegment.StreetscapingLightingValue = MapToLookupNames(streetSegment.StreetscapingLighting, lookupValues);
            streetSegment.SidewalksValue = MapToLookupNames(streetSegment.Sidewalks, lookupValues);
            streetSegment.CurbAndGutterValue = MapToLookupNames(streetSegment.CurbAndGutter, lookupValues);
        }

        MinorProjectLocationDTO minorProjectLocation = new()
        {
            MinorProjects = minorProjects,
            RequestLocation = new()
            {
                IsMappedRequest = capitalProjectItem.IsMappedRequest,
                GISMappingDescription = capitalProjectItem.GISMappingDescription,
            },
            StreetSegments = streetSegments,
        };

        FinancialDTO financial = new();

        var borrowingFundings = capitalProjectItem.BorrowingFundings.Adapt<List<BorrowingFundingDTO>>();
        foreach (var borrowingFunding in borrowingFundings)
        {
            borrowingFunding.ExpenditureCategoryName = MapToLookupNames(borrowingFunding.ExpenditureCategoryId.GetValueOrDefault(), lookupValues);
            borrowingFunding.FundingSourceName = MapToLookupNames(borrowingFunding.FundingSourceId.GetValueOrDefault(), lookupValues);
        }

        
        var operatingFundings = capitalProjectItem.OperatingFundings.Adapt<List<OperatingFundingDTO>>();
        foreach (var operatingFunding in operatingFundings)
        {
            operatingFunding.ExpenditureCategoryName = MapToLookupNames(operatingFunding.ExpenditureCategoryId.GetValueOrDefault(), lookupValues);
            operatingFunding.FundingSourceName = MapToLookupNames(operatingFunding.FundingSourceId.GetValueOrDefault(), lookupValues);
        }
        
        var grantFundings = capitalProjectItem.GrantFundings.Adapt<List<GrantFundingDTO>>();
        foreach (var grantFunding in grantFundings)
        {
            grantFunding.ExpenditureCategoryName = MapToLookupNames(grantFunding.ExpenditureCategoryId.GetValueOrDefault(), lookupValues);
            grantFunding.FundingSourceName = MapToLookupNames(grantFunding.FundingSourceId.GetValueOrDefault(), lookupValues);
        }
        
        var donationFundings = capitalProjectItem.DonationFundings.Adapt<List<DonationFundingDTO>>();
        foreach (var donationFunding in donationFundings)
        {
            donationFunding.ExpenditureCategoryName = MapToLookupNames(donationFunding.ExpenditureCategoryId.GetValueOrDefault(), lookupValues);
            donationFunding.FundingSourceName = MapToLookupNames(donationFunding.FundingSourceId.GetValueOrDefault(), lookupValues);
        }
        
        var specialFundings = capitalProjectItem.SpecialFundings.Adapt<List<SpecialFundingDTO>>();
        foreach (var specialFunding in specialFundings)
        {
            specialFunding.ExpenditureCategoryName = MapToLookupNames(specialFunding.ExpenditureCategoryId.GetValueOrDefault(), lookupValues);
            specialFunding.FundingSourceName = MapToLookupNames(specialFunding.FundingSourceId.GetValueOrDefault(), lookupValues);
        }
        
        var otherFundings = capitalProjectItem.OtherFundings.Adapt<List<OtherFundingDTO>>();
        foreach (var otherFunding in otherFundings)
        {
            otherFunding.ExpenditureCategoryName = MapToLookupNames(otherFunding.ExpenditureCategoryId.GetValueOrDefault(), lookupValues);
            otherFunding.FundingSourceName = MapToLookupNames(otherFunding.FundingSourceId.GetValueOrDefault(), lookupValues);
        }
        
        financial.Funding = new()
        {
            TIFFundingIds = capitalProjectItem.TIFFundingIds,
            TIFFundingValue = MapToLookupNames(capitalProjectItem.TIFFundingIds, lookupValues),
            BorrowingFundings = borrowingFundings,
            OperatingFundings = operatingFundings,
            GrantFundings = grantFundings,
            DonationFunding = new()
            {
                DonationFundingIsContributeFundsRequired = capitalProjectItem.DonationFundingIsContributeFundsRequired,
                DonationFundingIsDonatedFundsUsed = capitalProjectItem.DonationFundingIsDonatedFundsUsed,
                DonationArrangements = capitalProjectItem.DonationArrangements,
                AmountAdvanced  = capitalProjectItem.AmountAdvanced,
                AdvancedFundsDescription = capitalProjectItem.AdvancedFundsDescription,
                DonatedAmountCollected = capitalProjectItem.DonatedAmountCollected,
                AmountDonated = capitalProjectItem.AmountDonated,
                DonationFundings = donationFundings
            },
            SpecialFundings = specialFundings,
            OtherFundings = otherFundings,
        };
        
        var spendingBudgets = capitalProjectItem.SpendingBudgets.Adapt<List<SpendingBudgetDTO>>();
        foreach (var spendingBudget in spendingBudgets)
        {
            spendingBudget.ExpenditureCategoryName = MapToLookupNames(spendingBudget.ExpenditureCategoryId.GetValueOrDefault(), lookupValues);
            spendingBudget.SpendingPurposeName = MapToLookupNames(spendingBudget.SpendingPurposeId.GetValueOrDefault(), lookupValues);
        }
        
        financial.Spending = new()
        {
            SpendingBudgets = spendingBudgets,
        };
        
        var fundingChanges = capitalProjectItem.FundingChanges.Adapt<List<FundingChangeDTO>>();
        foreach (var fundingChange in fundingChanges)
        {
            fundingChange.ChangeSetValue = MapToLookupNames(fundingChange.ChangeSetId.GetValueOrDefault(), lookupValues);
            fundingChange.ChangeTypeValue = MapToLookupNames(fundingChange.ChangeTypeIds, lookupValues);
        }

        financial.Change = new()
        {
            FundingChanges = fundingChanges,
        };
        
        var pastFundings = capitalProjectItem.PastFundings.Adapt<List<PastFundingDTO>>();
        foreach (var pastFunding in pastFundings)
        {
            pastFunding.ExpenditureCategoryName = MapToLookupNames(pastFunding.ExpenditureCategoryId.GetValueOrDefault(), lookupValues);
            pastFunding.FundingSourceName = MapToLookupNames(pastFunding.FundingSourceId.GetValueOrDefault(), lookupValues);
            pastFunding.FundingSubSourceName = MapToLookupNames(pastFunding.FundingSubSourceId.GetValueOrDefault(), lookupValues);
        }
        
        var pastSpendings = capitalProjectItem.PastSpendings.Adapt<List<PastSpendingDTO>>();
        foreach (var pastSpending in pastSpendings)
        {
            pastSpending.ExpenditureCategoryName = MapToLookupNames(pastSpending.ExpenditureCategoryId.GetValueOrDefault(), lookupValues);
            pastSpending.SpendingPurposeName = MapToLookupNames(pastSpending.SpendingPurposeId.GetValueOrDefault(), lookupValues);
        }
        
        financial.Past = new()
        {
            PastFundings = pastFundings,
            PastSpendings = pastSpendings,
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

        var generalInformation = capitalProjectItem.GeneralInformation.Adapt<GeneralInformationDTO>();
        generalInformation.RequestingDepartmentValue =
            MapToLookupNames(generalInformation.RequestingDepartmentIds, lookupValues);
        generalInformation.DepartmentHeadRequestorValue = MapToLookupNames(generalInformation.DepartmentHeadRequestorId, lookupValues);
        generalInformation.RequestTypeValue = MapToLookupNames(generalInformation.RequestTypeId, lookupValues);
        generalInformation.RequestGroupValue = MapToLookupNames(generalInformation.RequestGroupId, lookupValues);

        return new GetCapitalProjectResponse(
            capitalProjectItem.Id,
            capitalProjectItem.BudgetId,
            capitalProjectItem.RevisionTitle,
            generalInformation,
            timeJustificationApproval,
            operatingBudgetImpact,
            minorProjectLocation,
            financial,
            capitalProjectItem.ProjectManagement.Adapt<ProjectManagementDTO>(),
            attachments
            );
    }
    
    public static string MapToLookupNames(string delimitedIds, List<LookupValueItem> items)
    {
        if (string.IsNullOrWhiteSpace(delimitedIds))
        {
            return string.Empty;
        }

        var ids = delimitedIds
            .Trim()
            .Split(",")
            .Select(id => Guid.Parse(id.Trim()));

        items = items.Where(x => ids.Contains(x.Id)).ToList();
        
        var names = items.Select(x => x.Name).ToList();
        return string.Join(", ", names);
    }

    public static string MapToLookupNames(Guid id, List<LookupValueItem> items)
    {
        return items.FirstOrDefault(x => x.Id == id)?.Name;
    }
    
}
