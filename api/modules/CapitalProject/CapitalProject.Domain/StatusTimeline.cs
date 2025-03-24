using FSH.Framework.Core.Domain;
using FSH.Framework.Core.Domain.Contracts;
using budget_request_app.WebApi.CapitalProject.Domain.Events;

namespace budget_request_app.WebApi.CapitalProject.Domain;

public class StatusTimeline : AuditableEntity, IAggregateRoot
{
    public string? StartYearMonth { get; set; }
    public string? EndYearMonth { get; set; }
    public string? CurrentStatus { get; set; }
    public string? DepartmentPointOfContactId { get; set; }
    public string? ReasonForMoreThanOneYear { get; set; }
}
