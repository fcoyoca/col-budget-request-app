using budget_request_app.WebApi.CapitalEquipment.Domain;
using budget_request_app.WebApi.CapitalEquipment.Infrastructure.SubModules.CapitalEquipments.Create.v1;

namespace budget_request_app.WebApi.CapitalEquipment.Infrastructure.SubModules.CapitalEquipments.Get.v1;

public static class CapitalEquipmentMapper
{
    public static GetCapitalEquipmentResponse GetResponse(CapitalEquipmentItem capitalEquipmentItem)
    {
        GeneralInfo generalInfo = new GeneralInfo()
        {
            RequestStatusId = capitalEquipmentItem.RequestStatusId,
            RemarksPrintout = capitalEquipmentItem.RemarksPrintout,
            RequestingDepartmentIds = capitalEquipmentItem.RequestingDepartmentIds,
            DepartmentHeadRequestorId = capitalEquipmentItem.DepartmentHeadRequestorId,
            EquipmentName = capitalEquipmentItem.EquipmentName,
            EquipmentCategoryId = capitalEquipmentItem.EquipmentCategoryId,
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

        FundingResponseDTO funding = new FundingResponseDTO()
        {
            BorrowingFunding = fundingItems.FirstOrDefault(x => x.FundingType == FundingTab.Borrowing),
            OueFunding = fundingItems.FirstOrDefault(x => x.FundingType == FundingTab.Operating),
            GrantFunding = fundingItems.FirstOrDefault(x => x.FundingType == FundingTab.Grant),
            OutsideFunding = fundingItems.FirstOrDefault(x => x.FundingType == FundingTab.Outside),
            SpecialFunding = fundingItems.FirstOrDefault(x => x.FundingType == FundingTab.Special),
            OtherFunding = fundingItems.FirstOrDefault(x => x.FundingType == FundingTab.Other),
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
