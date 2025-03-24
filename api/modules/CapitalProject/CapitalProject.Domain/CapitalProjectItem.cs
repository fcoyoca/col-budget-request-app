using FSH.Framework.Core.Domain;
using FSH.Framework.Core.Domain.Contracts;
using budget_request_app.WebApi.CapitalProject.Domain.Events;

namespace budget_request_app.WebApi.CapitalProject.Domain;
public class CapitalProjectItem : AuditableEntity, IAggregateRoot
{
    public string? BudgetId { get; set; }
    public string? RevisionTitle { get; set; }
    // 1st tab
    public GeneralInfomation GeneralInformation { get; set; }
    // 2nd tab
    public JustificationPrioritization JustificationPrioritization { get; set; }
    public GrantFundingOpportunity GrantFundingOpportunity { get; set; }
    public ApprovalOversight ApprovalOversight { get; set; }
    
    // 3rd tab
    public List<CapitalProjectOperatingCost>? OperatingCosts { get; set; }
    public List<CapitalProjectOperatingRevenue>? OperatingRevenues { get; set; }
    
    // tab4 - request location
    public bool? IsMappedRequest { get; set; } = false;
    public string? GISMappingDescription { get; set; }
    public List<CapitalProjectMinorProject>? MinorProjects { get; set; }
    public List<CapitalProjectStreetSegment>? StreetSegments { get; set; }
    
    // financials
    public List<BorrowingFunding> BorrowingFundings { get; set; }
    public List<OperatingFunding> OperatingFundings { get; set; }
    public List<GrantFunding> GrantFundings { get; set; }
    public List<DonationFunding> DonationFundings { get; set; }
    public bool? DonationFundingIsContributeFundsRequired { get; set; }
    public bool? DonationFundingIsDonatedFundsUsed { get; set; } = false;
    public List<SpecialFunding> SpecialFundings { get; set; }
    public List<OtherFunding> OtherFundings { get; set; }
    public List<FundingChange> FundingChanges { get; set; }
    public List<PastFunding> PastFundings { get; set; }
    public List<PastSpending> PastSpendings { get; set; }

    public static CapitalProjectItem Create(
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
        var CapitalProject = new CapitalProjectItem();

        CapitalProject.BudgetId = budgetId;
        CapitalProject.RevisionTitle = revisionTitle;
        CapitalProject.RequestId = requestId;
        CapitalProject.Title = title;
        CapitalProject.RequestStatusId = requestStatusId;
        CapitalProject.RemarksPrintout = remarksPrintout;
        CapitalProject.RequestingDepartmentIds = requestingDepartmentIds;
        CapitalProject.DepartmentHeadRequestorId = departmentHeadRequestorId;
        CapitalProject.EquipmentName = equipmentName;
        CapitalProject.EquipmentCategoryId = equipmentCategoryId;
        CapitalProject.IsNew = isNew;
        CapitalProject.IsReplacement = isReplacement;
        CapitalProject.IsLeasedVehicle = isLeasedVehicle;
        CapitalProject.Quantity = quantity;
        CapitalProject.UnitCost = unitCost;
        CapitalProject.EquipmentSummary = equipmentSummary;
        CapitalProject.DepartmentPriorityRanking = departmentPriorityRanking;
        CapitalProject.ExpectedOutcomes = expectedOutcomes;
        CapitalProject.PurposeOfExpenditure = purposeOfExpenditure;
        CapitalProject.JustificationForReplacement = justificationForReplacement;
        CapitalProject.RequiredMandatedPriority = requiredMandatedPriority;
        CapitalProject.SafetyPriority = safetyPriority;
        CapitalProject.PaybackPeriodPriority = paybackPeriodPriority;
        CapitalProject.SustainabilityPriority = sustainabilityPriority;
        CapitalProject.CostToOperatePriority = costToOperatePriority;
        CapitalProject.RevenueGenerationPriority = revenueGenerationPriority;
        CapitalProject.RequiredMandatedExplanation = requiredMandatedExplanation;
        CapitalProject.SafetyExplanation = safetyExplanation;
        CapitalProject.PaybackPeriodExplanation = paybackPeriodExplanation;
        CapitalProject.SustainabilityExplanation = sustainabilityExplanation;
        CapitalProject.CostToOperateExplanation = costToOperateExplanation;
        CapitalProject.RevenueGenerationExplanation = revenueGenerationExplanation;
        CapitalProject.AssetBeingReplaced = assetBeingReplaced;
        CapitalProject.ConditionOfAssetBeingReplaced = conditionOfAssetBeingReplaced;
        CapitalProject.OdometerReadingHours = odometerReadingHours;
        CapitalProject.StandardReplacementCycle = standardReplacementCycle;
        CapitalProject.EstimatedLifeOfEquipment = estimatedLifeOfEquipment;
        CapitalProject.DepartmentResponsibleForOperatingCosts = departmentResponsibleForOperatingCosts;
        CapitalProject.AnnualOperatingCosts = annualOperatingCosts;
        CapitalProject.AnnualRevenueFromEquipment = annualRevenueFromEquipment;
        CapitalProject.HasPurchaseBeenApprovedByOversight = hasPurchaseBeenApprovedByOversight;
        CapitalProject.LegistarApprovalItemNumber = legistarApprovalItemNumber;
        CapitalProject.ApprovingOversightBoard = approvingOversightBoard;
        CapitalProject.DateOfOversightApproval = dateOfOversightApproval;
        CapitalProject.PurchasingBuyerReview = purchasingBuyerReview;
        CapitalProject.AdditionalNotes = additionalNotes;
        CapitalProject.FundingItems = fundingItems;
        
        CapitalProject.QueueDomainEvent(new CapitalProjectCreated() { CapitalProject = CapitalProject });

        return CapitalProject;
    }

    public static CapitalProjectItem Update(
        CapitalProjectItem capitalEquipment,
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
        capitalEquipment.FundingItems = fundingItems;

        capitalEquipment.QueueDomainEvent(new CapitalProjectUpdated() { CapitalProject = capitalEquipment });

        return capitalEquipment;
    }
}
