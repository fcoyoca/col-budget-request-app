using budget_request_app.WebApi.CapitalEquipment.Domain;
using budget_request_app.WebApi.CapitalEquipment.Infrastructure.SubModules.CapitalEquipments.Create.v1;
using budget_request_app.WebApi.FileService.Domain;

namespace budget_request_app.WebApi.CapitalEquipment.Infrastructure.SubModules.CapitalEquipments.Get.v1;
public sealed record GetCapitalEquipmentResponse(
    Guid Id,
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
    FundingResponseDTO Funding,
    List<AttachmentDTO>? Attachments
    );

public class FundingResponseDTO
{
    public List<FundingItemDTO> BorrowingFundings { get; set; }
    public List<FundingItemDTO> OueFundings { get; set; }
    public List<FundingItemDTO> GrantFundings { get; set; }
    public List<FundingItemDTO> SpecialFundings { get; set; }
    public List<FundingItemDTO> OtherFundings { get; set; }
    public List<FundingItemDTO> OutsideFundings { get; set; }
    public List<CapitalEquipmentPastFundingDTO> PastFundings { get; set; }
}

public class FundingItemDTO
{
    public string FundingType  { get; set; }
    public Guid? FundingSource { get; set; } = Guid.Empty;
    public string? FundingSourceValue { get; set; }
    public string? GrantingAgency { get; set; }
    public string? GrantingAgencyValue { get; set; }
    public FundingYearItem? CurrentYearRequested { get; set; }
    public List<FundingYearItem>? YearEstimates { get; set; } = new();
}

public class CapitalEquipmentPastFundingDTO
{
    public string? Details { get; set; }
    public int? Year  { get; set; }
    public decimal? Amount { get; set; }
    public string? Request { get; set; }
    public Guid? FundingSource { get; set; } = Guid.Empty;
    public Guid? FundingSubSource { get; set; } = Guid.Empty;
    public string? SOF  { get; set; }
}

public class AttachmentDTO
{
    public string Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public double Size { get; set; }
    public string Type { get; set; } = string.Empty;
    public string FileName { get; set; } = string.Empty;
}

