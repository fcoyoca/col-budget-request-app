using FSH.Framework.Core.Domain;
using FSH.Framework.Core.Domain.Contracts;
using budget_request_app.WebApi.CapitalProject.Domain.Events;

namespace budget_request_app.WebApi.CapitalProject.Domain;

public class GeneralInformation : AuditableEntity, IAggregateRoot
{
    public int? RequestId { get; set; }
    public string? RequestStatusId { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public string? RequestingDepartmentIds { get; set; }
    public string? DepartmentHeadRequestorId { get; set; }
    public string? RequestTypeId { get; set; }
    public bool? RequiresTwoThirdsApproval { get; set; } = false;
    public string? RemarksPrintout { get; set; }
    public string? RequestGroupId { get; set; }
}
