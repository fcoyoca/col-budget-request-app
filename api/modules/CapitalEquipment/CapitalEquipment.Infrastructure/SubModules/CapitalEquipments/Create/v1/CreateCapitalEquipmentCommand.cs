using System.ComponentModel;
using budget_request_app.WebApi.CapitalEquipment.Domain;
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
    ApprovalOversightInfo ApprovalOversightInfo,
    FundingCreateDTO Funding,
    string? FileIds
) : IRequest<CreateCapitalEquipmentResponse>;

public class GeneralInfo
{
    public string RequestStatusId { get; set; }
    public string? RequestStatusValue { get; set; }
    public string RemarksPrintout { get; set; }
    public string RequestingDepartmentIds { get; set; }
    public string? RequestingDepartmentValue { get; set; }
    public string DepartmentHeadRequestorId { get; set; }
    public string? DepartmentHeadRequestorValue { get; set; }
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
    public decimal? OdometerReadingHours { get; set; }
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
    public Guid? ApprovingOversightBoard { get; set; }
    public DateTime? DateOfOversightApproval { get; set; }
    public bool? PurchasingBuyerReview { get; set; }
    public string AdditionalNotes { get; set; }
}

public class FundingCreateDTO
{
    public List<FundingItemCreateDTO> BorrowingFundings { get; set; }
    public List<FundingItemCreateDTO> OUEFundings { get; set; }
    public List<FundingItemCreateDTO> GrantFundings { get; set; }
    public List<FundingItemCreateDTO> OutsideFundings { get; set; }
    public List<FundingItemCreateDTO> SpecialFundings { get; set; }
    public List<FundingItemCreateDTO> OtherFundings { get; set; }
}

public class FundingItemCreateDTO
{
    //public Guid? Id { get; set; } = Guid.Empty;
    public Guid? FundingSource { get; set; } = Guid.Empty;
    public string? GrantingAgency { get; set; }
    public FundingYearItemCreateDTO CurrentYearRequested { get; set; }
    public List<FundingYearItemCreateDTO> YearEstimates { get; set; } = new List<FundingYearItemCreateDTO>();
}

public class FundingYearItemCreateDTO
{
    //public Guid? Id { get; set; } = Guid.Empty;
    public int? Year { get; set; }
    public decimal? Value { get; set; }
}

public static class FundingTab
{
    public static string Borrowing { get; } = "Borrowing";
    public static string Grant { get; } = "Grant";
    public static string Operating { get; } = "Operating";
    public static string Outside { get; } = "Outside";
    public static string Special { get; } = "Special";
    public static string Other { get; } = "Other";
}
