using budget_request_app.WebApi.CapitalEquipment.Domain;
using budget_request_app.WebApi.CapitalEquipment.Infrastructure.SubModules.CapitalEquipments.Create.v1;
using budget_request_app.WebApi.FileService.Domain;
using budget_request_app.WebApi.LookupValue.Domain;
using FSH.Framework.Core.Identity.Users.Dtos;
using Mapster;

namespace budget_request_app.WebApi.CapitalEquipment.Infrastructure.SubModules.CapitalEquipments.Get.v1;

public static class CapitalEquipmentMapper
{
    public static GetCapitalEquipmentResponse GetResponse(CapitalEquipmentItem capitalEquipmentItem, List<LookupValueItem> lookupValues, List<FileServiceItem> fileServiceItems, List<UserDetail> users)
    {
        var requestingDepartmentIds = capitalEquipmentItem.RequestingDepartmentIds.Split(",")
            .Select(x => x.Trim());
        var requestingDepartments = lookupValues.Where(
            x => requestingDepartmentIds.Contains(x.Id.ToString())
        ).Select(x => x.Name).ToList();

        var requestingDepartmentHeadIds = capitalEquipmentItem.DepartmentHeadRequestorId.Split(",")
            .Select(x => x.Trim());
        var requestingDepartmentHeads = lookupValues.Where(
            x => requestingDepartmentHeadIds.Contains(x.Id.ToString())
        ).Select(x => x.Name).ToList();


        var requestStatus = lookupValues.FirstOrDefault(x => x.Id.ToString() == capitalEquipmentItem.RequestStatusId);
        var requestStatusName = string.Empty;
        if (requestStatus != null)
        {
            requestStatusName = requestStatus.Name;
        }

        var equipmentCategoryName = lookupValues.FirstOrDefault(x => x.Id.ToString() == capitalEquipmentItem.EquipmentCategoryId)?.Name;

        GeneralInfo generalInfo = new GeneralInfo()
        {
            RequestStatusId = capitalEquipmentItem.RequestStatusId,
            RemarksPrintout = capitalEquipmentItem.RemarksPrintout,
            RequestingDepartmentIds = capitalEquipmentItem.RequestingDepartmentIds,
            DepartmentHeadRequestorId = capitalEquipmentItem.DepartmentHeadRequestorId,
            EquipmentName = capitalEquipmentItem.EquipmentName,
            EquipmentCategoryId = capitalEquipmentItem.EquipmentCategoryId,
            RequestingDepartmentValue = string.Join(",", requestingDepartments),
            DepartmentHeadRequestorValue = string.Join(",", requestingDepartmentHeads),
            RequestStatusValue = requestStatusName,
            EquipmentCategoryValue = equipmentCategoryName,
            ProjectNumber = capitalEquipmentItem.ProjectNumber,
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
            RequiredMandatedPriorityValue = lookupValues.FirstOrDefault(x => x.Id.ToString() == capitalEquipmentItem.RequiredMandatedPriority)?.Name,
            SafetyPriority = capitalEquipmentItem.SafetyPriority,
            SafetyPriorityValue = lookupValues.FirstOrDefault(x => x.Id.ToString() == capitalEquipmentItem.SafetyPriority)?.Name,
            PaybackPeriodPriority = capitalEquipmentItem.PaybackPeriodPriority,
            PaybackPeriodPriorityValue = lookupValues.FirstOrDefault(x => x.Id.ToString() == capitalEquipmentItem.PaybackPeriodPriority)?.Name,
            SustainabilityPriority = capitalEquipmentItem.SustainabilityPriority,
            SustainabilityPriorityValue = lookupValues.FirstOrDefault(x => x.Id.ToString() == capitalEquipmentItem.SustainabilityPriority)?.Name,
            CostToOperatePriority = capitalEquipmentItem.CostToOperatePriority,
            CostToOperatePriorityValue = lookupValues.FirstOrDefault(x => x.Id.ToString() == capitalEquipmentItem.CostToOperatePriority)?.Name,
            RevenueGenerationPriority = capitalEquipmentItem.RevenueGenerationPriority,
            RevenueGenerationPriorityValue = lookupValues.FirstOrDefault(x => x.Id.ToString() == capitalEquipmentItem.RevenueGenerationPriority)?.Name,
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
            OdometerReadingHours = Decimal.Parse(capitalEquipmentItem.OdometerReadingHours.Length > 0 ? capitalEquipmentItem.OdometerReadingHours : "0"),
            StandardReplacementCycle = capitalEquipmentItem.StandardReplacementCycle,
            EstimatedLifeOfEquipment = capitalEquipmentItem.EstimatedLifeOfEquipment,
        };

        OperatingBudgetImpact operatingBudgetImpact = new OperatingBudgetImpact()
        {
            DepartmentResponsibleForOperatingCosts = capitalEquipmentItem.DepartmentResponsibleForOperatingCosts,
            DepartmentResponsibleForOperatingCostsValue = lookupValues.FirstOrDefault(x => x.Id.ToString() == capitalEquipmentItem.DepartmentResponsibleForOperatingCosts)?.Name,
            AnnualOperatingCosts = capitalEquipmentItem.AnnualOperatingCosts,
            AnnualRevenueFromEquipment = capitalEquipmentItem.AnnualRevenueFromEquipment
        };

        ApprovalOversightInfo approvalOversightInfo = new ApprovalOversightInfo()
        {
            HasPurchaseBeenApprovedByOversight = capitalEquipmentItem.HasPurchaseBeenApprovedByOversight,
            LegistarApprovalItemNumber = capitalEquipmentItem.LegistarApprovalItemNumber,
            ApprovingOversightBoard = capitalEquipmentItem.ApprovingOversightBoard != string.Empty ? Guid.Parse(capitalEquipmentItem.ApprovingOversightBoard) : null,
            ApprovingOversightBoardValue = lookupValues.FirstOrDefault(x => x.Id.ToString() == capitalEquipmentItem.ApprovingOversightBoard)?.Name,
            DateOfOversightApproval = capitalEquipmentItem.DateOfOversightApproval,
            PurchasingBuyerReview = capitalEquipmentItem.PurchasingBuyerReview,
            AdditionalNotes = capitalEquipmentItem.AdditionalNotes,
        };

        List<FundingItemDTO> fundingItems = capitalEquipmentItem.FundingItems.Adapt<List<FundingItemDTO>>();

        foreach (FundingItemDTO fundingItem in fundingItems)
        {
            fundingItem.FundingSourceValue = lookupValues.FirstOrDefault(x => x.Id == fundingItem.FundingSource)?.Name;
            fundingItem.GrantingAgencyValue = lookupValues.FirstOrDefault(x => x.Id.ToString() == fundingItem.GrantingAgency)?.Name;
        }

        var pastFundings = capitalEquipmentItem.PastFundings.Adapt<List<CapitalEquipmentPastFundingDTO>>();

        if (pastFundings == null)
        {
            pastFundings = new List<CapitalEquipmentPastFundingDTO>();
        }

        foreach (CapitalEquipmentPastFundingDTO pastFunding in pastFundings)
        {
            pastFunding.FundingSourceValue = lookupValues.FirstOrDefault(x => x.Id == pastFunding.FundingSource)?.Name;
            pastFunding.FundingSubSourceValue = lookupValues.FirstOrDefault(x => x.Id == pastFunding.FundingSubSource)?.Name;
        }

        FundingResponseDTO funding = new()
        {
            BorrowingFundings = fundingItems.Where(x => x.FundingType == FundingTab.Borrowing).ToList(),
            OueFundings = fundingItems.Where(x => x.FundingType == FundingTab.Operating).ToList(),
            GrantFundings = fundingItems.Where(x => x.FundingType == FundingTab.Grant).ToList(),
            OutsideFundings = fundingItems.Where(x => x.FundingType == FundingTab.Outside).ToList(),
            SpecialFundings = fundingItems.Where(x => x.FundingType == FundingTab.Special).ToList(),
            OtherFundings = fundingItems.Where(x => x.FundingType == FundingTab.Other).ToList(),
            PastFundings = pastFundings
        };

        var attachments = new List<AttachmentDTO>();
        var imageFile = new ImageFileDTO();

        if (capitalEquipmentItem.FileIds != string.Empty)
        {
            var attachmentIds = capitalEquipmentItem.FileIds.Trim().Split(",");
            var guids = attachmentIds.Select(Guid.Parse);
            attachments = fileServiceItems.Where(x => guids.Contains(x.Id)).Adapt<List<AttachmentDTO>>();

            foreach (var attachment in attachments)
            {
                attachment.Type = Path.GetExtension(attachment.FileName);
            }
        }

        string? createdByFullName = users.FirstOrDefault(x => x.Id == capitalEquipmentItem.CreatedBy)!.FullName ?? string.Empty;
        string? lastModifiedByFullName = users.FirstOrDefault(x => x.Id == capitalEquipmentItem.LastModifiedBy)!.FullName ?? string.Empty;

        return new GetCapitalEquipmentResponse(
            capitalEquipmentItem.Id,
            capitalEquipmentItem.RequestNumber ?? 0,
            capitalEquipmentItem.ProjectNumber,
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
            funding,
            attachments,
            capitalEquipmentItem.ImageId,
            capitalEquipmentItem.IsDraft,
            capitalEquipmentItem.Created,
            capitalEquipmentItem.CreatedBy,
            createdByFullName,
            capitalEquipmentItem.LastModified,
            capitalEquipmentItem.LastModifiedBy!.Value,
            lastModifiedByFullName
            );
    }
}
