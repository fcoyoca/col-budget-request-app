using budget_request_app.WebApi.CapitalEquipment.Domain;
using budget_request_app.WebApi.CapitalEquipment.Infrastructure.SubModules.CapitalEquipments.Create.v1;
using MediatR;

namespace budget_request_app.WebApi.CapitalEquipment.Infrastructure.SubModules.CapitalEquipments.Update.v1;
public sealed record UpdateCapitalEquipmentCommand(
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
    FundingCreateDTO Funding,
    string FileIds
    ) : IRequest<UpdateCapitalEquipmentResponse>;


public class FundingUpdateDTO
{
    public FundingItemCreateDTO BorrowingFunding { get; set; }

    public FundingItemCreateDTO OUEFunding { get; set; }
}

public class FundingItemUpdateDTO
{
    public Guid? Id { get; set; }
    public Guid? FundingSource { get; set; } = Guid.Empty;
    public string? GrantingAgency { get; set; }
}
