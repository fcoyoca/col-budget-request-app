using System.ComponentModel.DataAnnotations;
using budget_request_app.WebApi.CapitalProject.Domain.Events;
using FSH.Framework.Core.Domain;
using FSH.Framework.Core.Domain.Contracts;

namespace budget_request_app.WebApi.CapitalProject.Domain;

public class StatusTimeline : AuditableEntity, IAggregateRoot
{
    [StringLength(140)]
    public string? StartYearMonth { get; set; }
    [StringLength(140)]
    public string? EndYearMonth { get; set; }
    [StringLength(160)]
    public string? CurrentStatus { get; set; }
    [StringLength(500)]
    public string? DepartmentPointOfContactId { get; set; }
    [StringLength(500)]
    public string? ReasonForMoreThanOneYear { get; set; }
}
