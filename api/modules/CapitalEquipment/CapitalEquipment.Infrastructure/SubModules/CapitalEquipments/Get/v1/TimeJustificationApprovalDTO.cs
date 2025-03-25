using budget_request_app.WebApi.CapitalProject.Domain;
using JustificationPrioritization = budget_request_app.WebApi.CapitalEquipment.Infrastructure.SubModules.CapitalEquipments.Create.v1.JustificationPrioritization;

namespace budget_request_app.WebApi.CapitalEquipment.Infrastructure.SubModules.CapitalEquipments.Get.v1;

public class TimeJustificationApprovalDTO
{
    public JustificationPrioritization? JustificationPrioritization { get; set; } 
    public GrantFundingOpportunity? GrantFundingOpportunity { get; set; }
    public ApprovalOversight? ApprovalOversight { get; set; }
}

