using FSH.Framework.Core.Domain;
using FSH.Framework.Core.Domain.Contracts;
using budget_request_app.WebApi.CapitalProject.Domain.Events;
using System.ComponentModel.DataAnnotations;

namespace budget_request_app.WebApi.CapitalProject.Domain;

public class GeneralInformation : AuditableEntity, IAggregateRoot
{
    public int? RequestId { get; set; }
    [StringLength(160)]
    public string? RequestStatusId { get; set; }
    [StringLength(220)]
    public string? Title { get; set; }
    [StringLength(500)]
    public string? Description { get; set; }
    [StringLength(600)]
    public string? RequestingDepartmentIds { get; set; }
    [StringLength(600)]
    public string? DepartmentHeadRequestorId { get; set; }
    [StringLength(160)]
    public string? RequestTypeId { get; set; }
    public bool? RequiresTwoThirdsApproval { get; set; } = false;
    public string? RemarksPrintout { get; set; }
    [StringLength(600)]
    public string? RequestGroupId { get; set; }
}
