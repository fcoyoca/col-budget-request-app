using FSH.Framework.Core.Domain;
using FSH.Framework.Core.Domain.Contracts;
using budget_request_app.WebApi.CapitalEquipment.Domain.Events;

namespace budget_request_app.WebApi.CapitalEquipment.Domain;
public class CapitalEquipmentItem : AuditableEntity, IAggregateRoot
{
    public string BudgetId { get; set; }
    public string RevisionTitle { get; set; }
    public int RequestId { get; set; }
    public string Title { get; set; }
    public string RequestStatusId { get; set; }
    public string RemarksPrintout { get; set; }
    public string RequestingDepartmentIds { get; set; }
    public string DepartmentHeadRequestorId { get; set; }
    public string EquipmentName { get; set; }
    public string EquipmentCategoryId { get; set; }
    public bool IsNew { get; set; }
    public bool IsReplacement { get; set; }
    public bool? IsLeasedVehicle { get; set; }
    public int? Quantity { get; set; }
    public Decimal? UnitCost { get; set; }
    public string EquipmentSummary { get; set; }
    public int? DepartmentPriorityRanking { get; set; } = 0;
    public string ExpectedOutcomes { get; set; } = string.Empty;
    public string PurposeOfExpenditure { get; set; } = string.Empty;
    public string JustificationForReplacement { get; set; } = string.Empty;
    public string RequiredMandatedPriority { get; set; }
    public string SafetyPriority { get; set; }
    public string PaybackPeriodPriority { get; set; }
    public string SustainabilityPriority { get; set; }
    public string CostToOperatePriority { get; set; }
    public string RevenueGenerationPriority { get; set; }
    
    public string RequiredMandatedExplanation { get; set; }
    public string SafetyExplanation { get; set; }
    public string PaybackPeriodExplanation { get; set; }
    public string SustainabilityExplanation { get; set; }
    public string CostToOperateExplanation { get; set; }
    public string RevenueGenerationExplanation { get; set; }
    public string AssetBeingReplaced { get; set; }
    public string ConditionOfAssetBeingReplaced { get; set; }
    public string OdometerReadingHours { get; set; }
    public string StandardReplacementCycle { get; set; }
    public int? EstimatedLifeOfEquipment { get; set; }
    public string DepartmentResponsibleForOperatingCosts { get; set; }
    public decimal? AnnualOperatingCosts { get; set; }
    public decimal AnnualRevenueFromEquipment { get; set; }
    public bool? HasPurchaseBeenApprovedByOversight { get; set; }
    public string LegistarApprovalItemNumber { get; set; }
    public string ApprovingOversightBoard { get; set; }
    public DateTime? DateOfOversightApproval { get; set; }
    public bool? PurchasingBuyerReview { get; set; }
    public string AdditionalNotes { get; set; }
    public List<FundingItem> FundingItems { get; set; }

    public static CapitalEquipmentItem Create(
        string budgetId,
        string revisionTitle,
        int requestId,
        string title,
        string requestStatusId,
        string remarksPrintout,
        string requestingDepartmentIds,
        string departmentHeadRequestorId,
        string equipmentName,
        string equipmentCategoryId,
        bool isNew,
        bool isReplacement,
        bool? isLeasedVehicle,
        int? quantity,
        decimal? unitCost,
        string equipmentSummary,
        int? departmentPriorityRanking,
        string expectedOutcomes,
        string purposeOfExpenditure,
        string justificationForReplacement,
        string requiredMandatedPriority,
        string safetyPriority,
        string paybackPeriodPriority,
        string sustainabilityPriority,
        string costToOperatePriority,
        string revenueGenerationPriority,
        string requiredMandatedExplanation,
        string safetyExplanation,
        string paybackPeriodExplanation,
        string sustainabilityExplanation,
        string costToOperateExplanation,
        string revenueGenerationExplanation,
        string assetBeingReplaced,
        string conditionOfAssetBeingReplaced,
        string odometerReadingHours,
        string standardReplacementCycle,
        int? estimatedLifeOfEquipment,
        string departmentResponsibleForOperatingCosts,
        decimal? annualOperatingCosts,
        decimal annualRevenueFromEquipment,
        bool? hasPurchaseBeenApprovedByOversight,
        string legistarApprovalItemNumber,
        string approvingOversightBoard,
        DateTime? dateOfOversightApproval,
        bool? purchasingBuyerReview,
        string additionalNotes,
        List<FundingItem> fundingItems
        )
    {
        var CapitalEquipment = new CapitalEquipmentItem();

        CapitalEquipment.BudgetId = budgetId;
        CapitalEquipment.RevisionTitle = revisionTitle;
        CapitalEquipment.RequestId = requestId;
        CapitalEquipment.Title = title;
        CapitalEquipment.RequestStatusId = requestStatusId;
        CapitalEquipment.RemarksPrintout = remarksPrintout;
        CapitalEquipment.RequestingDepartmentIds = requestingDepartmentIds;
        CapitalEquipment.DepartmentHeadRequestorId = departmentHeadRequestorId;
        CapitalEquipment.EquipmentName = equipmentName;
        CapitalEquipment.EquipmentCategoryId = equipmentCategoryId;
        CapitalEquipment.IsNew = isNew;
        CapitalEquipment.IsReplacement = isReplacement;
        CapitalEquipment.IsLeasedVehicle = isLeasedVehicle;
        CapitalEquipment.Quantity = quantity;
        CapitalEquipment.UnitCost = unitCost;
        CapitalEquipment.EquipmentSummary = equipmentSummary;
        CapitalEquipment.DepartmentPriorityRanking = departmentPriorityRanking;
        CapitalEquipment.ExpectedOutcomes = expectedOutcomes;
        CapitalEquipment.PurposeOfExpenditure = purposeOfExpenditure;
        CapitalEquipment.JustificationForReplacement = justificationForReplacement;
        CapitalEquipment.RequiredMandatedPriority = requiredMandatedPriority;
        CapitalEquipment.SafetyPriority = safetyPriority;
        CapitalEquipment.PaybackPeriodPriority = paybackPeriodPriority;
        CapitalEquipment.SustainabilityPriority = sustainabilityPriority;
        CapitalEquipment.CostToOperatePriority = costToOperatePriority;
        CapitalEquipment.RevenueGenerationPriority = revenueGenerationPriority;
        CapitalEquipment.RequiredMandatedExplanation = requiredMandatedExplanation;
        CapitalEquipment.SafetyExplanation = safetyExplanation;
        CapitalEquipment.PaybackPeriodExplanation = paybackPeriodExplanation;
        CapitalEquipment.SustainabilityExplanation = sustainabilityExplanation;
        CapitalEquipment.CostToOperateExplanation = costToOperateExplanation;
        CapitalEquipment.RevenueGenerationExplanation = revenueGenerationExplanation;
        CapitalEquipment.AssetBeingReplaced = assetBeingReplaced;
        CapitalEquipment.ConditionOfAssetBeingReplaced = conditionOfAssetBeingReplaced;
        CapitalEquipment.OdometerReadingHours = odometerReadingHours;
        CapitalEquipment.StandardReplacementCycle = standardReplacementCycle;
        CapitalEquipment.EstimatedLifeOfEquipment = estimatedLifeOfEquipment;
        CapitalEquipment.DepartmentResponsibleForOperatingCosts = departmentResponsibleForOperatingCosts;
        CapitalEquipment.AnnualOperatingCosts = annualOperatingCosts;
        CapitalEquipment.AnnualRevenueFromEquipment = annualRevenueFromEquipment;
        CapitalEquipment.HasPurchaseBeenApprovedByOversight = hasPurchaseBeenApprovedByOversight;
        CapitalEquipment.LegistarApprovalItemNumber = legistarApprovalItemNumber;
        CapitalEquipment.ApprovingOversightBoard = approvingOversightBoard;
        CapitalEquipment.DateOfOversightApproval = dateOfOversightApproval;
        CapitalEquipment.PurchasingBuyerReview = purchasingBuyerReview;
        CapitalEquipment.AdditionalNotes = additionalNotes;
        CapitalEquipment.FundingItems = fundingItems;
        
        CapitalEquipment.QueueDomainEvent(new CapitalEquipmentCreated() { CapitalEquipment = CapitalEquipment });

        return CapitalEquipment;
    }

    public static CapitalEquipmentItem Update(
        CapitalEquipmentItem capitalEquipment,
        string budgetId,
        string revisionTitle,
        int requestId,
        string title,
        string requestStatusId,
        string remarksPrintout,
        string requestingDepartmentIds,
        string departmentHeadRequestorId,
        string equipmentName,
        string equipmentCategoryId,
        bool isNew,
        bool isReplacement,
        bool? isLeasedVehicle,
        int? quantity,
        decimal? unitCost,
        string equipmentSummary,
        int? departmentPriorityRanking,
        string expectedOutcomes,
        string purposeOfExpenditure,
        string justificationForReplacement,
        string requiredMandatedPriority,
        string safetyPriority,
        string paybackPeriodPriority,
        string sustainabilityPriority,
        string costToOperatePriority,
        string revenueGenerationPriority,
        string requiredMandatedExplanation,
        string safetyExplanation,
        string paybackPeriodExplanation,
        string sustainabilityExplanation,
        string costToOperateExplanation,
        string revenueGenerationExplanation,
        string assetBeingReplaced,
        string conditionOfAssetBeingReplaced,
        string odometerReadingHours,
        string standardReplacementCycle,
        int? estimatedLifeOfEquipment,
        string departmentResponsibleForOperatingCosts,
        decimal? annualOperatingCosts,
        decimal annualRevenueFromEquipment,
        bool? hasPurchaseBeenApprovedByOversight,
        string legistarApprovalItemNumber,
        string approvingOversightBoard,
        DateTime? dateOfOversightApproval,
        bool? purchasingBuyerReview,
        string additionalNotes
        )
    {

        capitalEquipment.BudgetId = budgetId;
        capitalEquipment.RevisionTitle = revisionTitle;
        capitalEquipment.RequestId = requestId;
        capitalEquipment.Title = title;
        capitalEquipment.RequestStatusId = requestStatusId;
        capitalEquipment.RemarksPrintout = remarksPrintout;
        capitalEquipment.RequestingDepartmentIds = requestingDepartmentIds;
        capitalEquipment.DepartmentHeadRequestorId = departmentHeadRequestorId;
        capitalEquipment.EquipmentName = equipmentName;
        capitalEquipment.EquipmentCategoryId = equipmentCategoryId;
        capitalEquipment.IsNew = isNew;
        capitalEquipment.IsReplacement = isReplacement;
        capitalEquipment.IsLeasedVehicle = isLeasedVehicle;
        capitalEquipment.Quantity = quantity;
        capitalEquipment.UnitCost = unitCost;
        capitalEquipment.EquipmentSummary = equipmentSummary;
        capitalEquipment.DepartmentPriorityRanking = departmentPriorityRanking;
        capitalEquipment.ExpectedOutcomes = expectedOutcomes;
        capitalEquipment.PurposeOfExpenditure = purposeOfExpenditure;
        capitalEquipment.JustificationForReplacement = justificationForReplacement;
        capitalEquipment.RequiredMandatedPriority = requiredMandatedPriority;
        capitalEquipment.SafetyPriority = safetyPriority;
        capitalEquipment.PaybackPeriodPriority = paybackPeriodPriority;
        capitalEquipment.SustainabilityPriority = sustainabilityPriority;
        capitalEquipment.CostToOperatePriority = costToOperatePriority;
        capitalEquipment.RevenueGenerationPriority = revenueGenerationPriority;
        capitalEquipment.RequiredMandatedExplanation = requiredMandatedExplanation;
        capitalEquipment.SafetyExplanation = safetyExplanation;
        capitalEquipment.PaybackPeriodExplanation = paybackPeriodExplanation;
        capitalEquipment.SustainabilityExplanation = sustainabilityExplanation;
        capitalEquipment.CostToOperateExplanation = costToOperateExplanation;
        capitalEquipment.RevenueGenerationExplanation = revenueGenerationExplanation;
        capitalEquipment.AssetBeingReplaced = assetBeingReplaced;
        capitalEquipment.ConditionOfAssetBeingReplaced = conditionOfAssetBeingReplaced;
        capitalEquipment.OdometerReadingHours = odometerReadingHours;
        capitalEquipment.StandardReplacementCycle = standardReplacementCycle;
        capitalEquipment.EstimatedLifeOfEquipment = estimatedLifeOfEquipment;
        capitalEquipment.DepartmentResponsibleForOperatingCosts = departmentResponsibleForOperatingCosts;
        capitalEquipment.AnnualOperatingCosts = annualOperatingCosts;
        capitalEquipment.AnnualRevenueFromEquipment = annualRevenueFromEquipment;
        capitalEquipment.HasPurchaseBeenApprovedByOversight = hasPurchaseBeenApprovedByOversight;
        capitalEquipment.LegistarApprovalItemNumber = legistarApprovalItemNumber;
        capitalEquipment.ApprovingOversightBoard = approvingOversightBoard;
        capitalEquipment.DateOfOversightApproval = dateOfOversightApproval;
        capitalEquipment.PurchasingBuyerReview = purchasingBuyerReview;
        capitalEquipment.AdditionalNotes = additionalNotes;

        capitalEquipment.QueueDomainEvent(new CapitalEquipmentUpdated() { CapitalEquipment = capitalEquipment });

        return capitalEquipment;
    }
}
