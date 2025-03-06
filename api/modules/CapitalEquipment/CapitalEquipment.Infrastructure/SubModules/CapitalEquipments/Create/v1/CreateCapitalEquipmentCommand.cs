using System.ComponentModel;
using MediatR;

namespace budget_request_app.WebApi.CapitalEquipment.Infrastructure.SubModules.CapitalEquipments.Create.v1;

public sealed record CreateCapitalEquipmentCommand(
    string BudgetId,
    string RevisionTitle,
    int RequestId,
    string Title,
    GeneralInfo GeneralInfo,
    EquipmentInfo EquipmentInfo,
    JustificationPrioritization JustificationPrioritization,
    JustificationMatrix JustificationMatrix,
    ExistingAssetInfo ExistingAssetInfo,
    OperatingBudgetImpact OperatingBudgetImpact,
    ApprovalOversightInfo ApprovalOversightInfo
) : IRequest<CreateCapitalEquipmentResponse>;

public class GeneralInfo
{
    public string RequestStatusId { get; set; }
    public string RemarksPrintout { get; set; }
    public string RequestingDepartmentIds { get; set; }
    public string DepartmentHeadRequestorId { get; set; }
    public string EquipmentName { get; set; }
    public string EquipmentCategoryId { get; set; }
}

public class EquipmentInfo
{
    public bool IsNew  { get; set; }
    public bool IsReplacement { get; set; }
    public bool? IsLeasedVehicle { get; set; }
    public int? Quantity { get; set; }
    public decimal? UnitCost  { get; set; }
    public string EquipmentSummary { get; set; }
}

public class JustificationPrioritization
{
    public int? DepartmentPriorityRanking { get; set; }
    public string ExpectedOutcomes { get; set; }
    public string PurposeOfExpenditure { get; set; }
    public string JustificationForReplacement { get; set; }
}

public class JustificationMatrix
{
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
}

public class ExistingAssetInfo
{
    public string AssetBeingReplaced { get; set; }
    public string ConditionOfAssetBeingReplaced { get; set; }
    public string OdometerReadingHours { get; set; }
    public string StandardReplacementCycle { get; set; }
    public int? EstimatedLifeOfEquipment { get; set; }
}

public class OperatingBudgetImpact
{
    public string DepartmentResponsibleForOperatingCosts { get; set; }
    public decimal? AnnualOperatingCosts { get; set; }
    public decimal AnnualRevenueFromEquipment { get; set; }
}

public class ApprovalOversightInfo
{
    public bool? HasPurchaseBeenApprovedByOversight { get; set; }
    public string LegistarApprovalItemNumber { get; set; }
    public string ApprovingOversightBoard { get; set; }
    public DateTime? DateOfOversightApproval { get; set; }
    public bool? PurchasingBuyerReview { get; set; }
    public string AdditionalNotes { get; set; }
}
