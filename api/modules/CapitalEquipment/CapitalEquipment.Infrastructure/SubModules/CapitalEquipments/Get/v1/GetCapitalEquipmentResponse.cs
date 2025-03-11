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
    public List<FundingItem> BorrowingFunding { get; set; }
    public List<FundingItem> OueFunding { get; set; }
    public List<FundingItem> GrantFunding { get; set; }
    public List<FundingItem> SpecialFunding { get; set; }
    public List<FundingItem> OtherFunding { get; set; }
    public List<FundingItem> OutsideFunding { get; set; }
}

