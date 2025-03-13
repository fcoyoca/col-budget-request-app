using budget_request_app.WebApi.CapitalEquipment.Domain;
using budget_request_app.WebApi.CapitalEquipment.Infrastructure.SubModules.CapitalEquipments.Create.v1;
using budget_request_app.WebApi.LookupValue.Domain;

namespace budget_request_app.WebApi.CapitalEquipment.Infrastructure.SubModules.CapitalEquipments.Get.v1;

public static class CapitalEquipmentMapper
{
    public static GetCapitalEquipmentResponse GetResponse(CapitalEquipmentItem capitalEquipmentItem, List<LookupValueItem> lookupValues)
    {
        var requestingDepartmentIds = capitalEquipmentItem.RequestingDepartmentIds.Split(",");
        var requestingDepartments = lookupValues.Where(
            x => requestingDepartmentIds.Contains(x.Id.ToString())
        ).Select(x => x.Name).ToList();
        
        var departmentHeadRequestor = lookupValues.FirstOrDefault(x => x.Id.ToString() == capitalEquipmentItem.DepartmentHeadRequestorId);
        var departmentHeadRequestorName = string.Empty;
        
        if (departmentHeadRequestor != null)
        {
            departmentHeadRequestorName = departmentHeadRequestor.Name;
        }
        
        var requestStatus = lookupValues.FirstOrDefault(x => x.Id.ToString() == capitalEquipmentItem.RequestStatusId);
        var requestStatusName = string.Empty;
        if (requestStatus != null)
        {
            requestStatusName = requestStatus.Name;
        }

        GeneralInfo generalInfo = new GeneralInfo()
        {
            RequestStatusId = capitalEquipmentItem.RequestStatusId,
            RemarksPrintout = capitalEquipmentItem.RemarksPrintout,
            RequestingDepartmentIds = capitalEquipmentItem.RequestingDepartmentIds,
            DepartmentHeadRequestorId = capitalEquipmentItem.DepartmentHeadRequestorId,
            EquipmentName = capitalEquipmentItem.EquipmentName,
            EquipmentCategoryId = capitalEquipmentItem.EquipmentCategoryId,
            RequestingDepartmentValue = string.Join(",", requestingDepartments),
            DepartmentHeadRequestorValue = departmentHeadRequestorName,
            RequestStatusValue = requestStatusName
            
        };

        EquipmentInfo equipmentInfo = new EquipmentInfo()
        {
            IsNew = capitalEquipmentItem.IsNew,
            IsReplacement = capitalEquipmentItem.IsReplacement,
            IsLeasedVehicle = capitalEquipmentItem.IsLeasedVehicle,
            Quantity = capitalEquipmentItem.Quantity,
            UnitCost = capitalEquipmentItem.UnitCost,
            EquipmentSummary = capitalEquipmentItem.EquipmentSummary,
        };

        JustificationPrioritization justificationPrioritization = new JustificationPrioritization()
        {
            DepartmentPriorityRanking = capitalEquipmentItem.DepartmentPriorityRanking,
            ExpectedOutcomes = capitalEquipmentItem.ExpectedOutcomes,
            PurposeOfExpenditure = capitalEquipmentItem.PurposeOfExpenditure,
            JustificationForReplacement = capitalEquipmentItem.JustificationForReplacement
        };

        JustificationMatrix justificationMatrix = new JustificationMatrix()
        {
            RequiredMandatedPriority = capitalEquipmentItem.RequiredMandatedPriority,
            SafetyPriority = capitalEquipmentItem.SafetyPriority,
            PaybackPeriodPriority = capitalEquipmentItem.PaybackPeriodPriority,
            SustainabilityPriority = capitalEquipmentItem.SustainabilityPriority,
            CostToOperatePriority = capitalEquipmentItem.CostToOperatePriority,
            RevenueGenerationPriority = capitalEquipmentItem.RevenueGenerationPriority,
            RequiredMandatedExplanation = capitalEquipmentItem.RequiredMandatedExplanation,
            SafetyExplanation = capitalEquipmentItem.SafetyExplanation,
            PaybackPeriodExplanation = capitalEquipmentItem.PaybackPeriodExplanation,
            SustainabilityExplanation = capitalEquipmentItem.SustainabilityExplanation,
            CostToOperateExplanation = capitalEquipmentItem.CostToOperateExplanation,
            RevenueGenerationExplanation = capitalEquipmentItem.RevenueGenerationExplanation
        };

        ExistingAssetInfo existingAssetInfo = new ExistingAssetInfo()
        {
            AssetBeingReplaced = capitalEquipmentItem.AssetBeingReplaced,
            ConditionOfAssetBeingReplaced = capitalEquipmentItem.ConditionOfAssetBeingReplaced,
            OdometerReadingHours = capitalEquipmentItem.OdometerReadingHours,
            StandardReplacementCycle = capitalEquipmentItem.StandardReplacementCycle,
            EstimatedLifeOfEquipment = capitalEquipmentItem.EstimatedLifeOfEquipment,
        };

        OperatingBudgetImpact operatingBudgetImpact = new OperatingBudgetImpact()
        {
            DepartmentResponsibleForOperatingCosts = capitalEquipmentItem.DepartmentResponsibleForOperatingCosts,
            AnnualOperatingCosts = capitalEquipmentItem.AnnualOperatingCosts,
            AnnualRevenueFromEquipment = capitalEquipmentItem.AnnualRevenueFromEquipment
        };

        ApprovalOversightInfo approvalOversightInfo = new ApprovalOversightInfo()
        {
            HasPurchaseBeenApprovedByOversight = !capitalEquipmentItem.HasPurchaseBeenApprovedByOversight,
            LegistarApprovalItemNumber = capitalEquipmentItem.LegistarApprovalItemNumber,
            ApprovingOversightBoard = capitalEquipmentItem.ApprovingOversightBoard,
            DateOfOversightApproval = capitalEquipmentItem.DateOfOversightApproval,
            PurchasingBuyerReview = capitalEquipmentItem.PurchasingBuyerReview,
            AdditionalNotes = capitalEquipmentItem.AdditionalNotes,
        };

        List<FundingItem> fundingItems = capitalEquipmentItem.FundingItems;
        
        FundingResponseDTO funding = new()
        {
            BorrowingFundings = fundingItems.Where(x => x.FundingType == FundingTab.Borrowing).ToList(),
            OueFundings = fundingItems.Where(x => x.FundingType == FundingTab.Operating).ToList(),
            GrantFundings = fundingItems.Where(x => x.FundingType == FundingTab.Grant).ToList(),
            OutsideFundings = fundingItems.Where(x => x.FundingType == FundingTab.Outside).ToList(),
            SpecialFundings = fundingItems.Where(x => x.FundingType == FundingTab.Special).ToList(),
            OtherFundings = fundingItems.Where(x => x.FundingType == FundingTab.Other).ToList(),
        };

        return new GetCapitalEquipmentResponse(
            capitalEquipmentItem.Id,
            capitalEquipmentItem.BudgetId,
            capitalEquipmentItem.RevisionTitle,
            capitalEquipmentItem.RequestId,
            capitalEquipmentItem.Title,
            generalInfo,
            equipmentInfo,
            justificationPrioritization,
            justificationMatrix,
            existingAssetInfo,
            operatingBudgetImpact,
            approvalOversightInfo,
            funding
            );
    }
}
