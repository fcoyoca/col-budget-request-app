using budget_request_app.WebApi.CapitalEquipment.Domain;
using budget_request_app.WebApi.CapitalEquipment.Infrastructure.SubModules.CapitalEquipments.Create.v1;

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
    FundingResponseDTO Funding
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

