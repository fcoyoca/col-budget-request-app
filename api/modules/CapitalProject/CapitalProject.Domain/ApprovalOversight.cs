using FSH.Framework.Core.Domain;
using FSH.Framework.Core.Domain.Contracts;
using budget_request_app.WebApi.CapitalProject.Domain.Events;

namespace budget_request_app.WebApi.CapitalProject.Domain;

public class ApprovalOversight : AuditableEntity, IAggregateRoot
{
    public bool? PartOfApprovedMasterPlan  { get; set; } = false;
    public bool? HasRequestBeenApprovedByOversight { get; set; } = false;
    public Guid? ApprovingOversightBoardId { get; set; }
    public DateTime? DateOfOversightApproval { get; set; }
    public string? LegistarApprovalNumber { get; set; }
    public bool? HasRequiredOtherApproval { get; set; } = false;
    public bool? HasReceivedOtherApproval { get; set; } = false;
    public string? ReceivedOtherApprovals { get; set; }
    public string? RemainingOtherApprovals { get; set; }
}
