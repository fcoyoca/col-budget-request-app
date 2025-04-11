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
    public List<FundingItem> BorrowingFundings { get; set; }
    public List<FundingItem> OueFundings { get; set; }
    public List<FundingItem> GrantFundings { get; set; }
    public List<FundingItem> SpecialFundings { get; set; }
    public List<FundingItem> OtherFundings { get; set; }
    public List<FundingItem> OutsideFundings { get; set; }
}

public class AttachmentDTO
{
    public string Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public double Size { get; set; }
    public string Type { get; set; } = string.Empty;
    public string FileName { get; set; } = string.Empty;
}

