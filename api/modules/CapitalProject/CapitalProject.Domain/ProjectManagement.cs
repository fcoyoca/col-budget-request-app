using System.ComponentModel.DataAnnotations;
using budget_request_app.WebApi.CapitalProject.Domain.Events;
using FSH.Framework.Core.Domain;
using FSH.Framework.Core.Domain.Contracts;

namespace budget_request_app.WebApi.CapitalProject.Domain;

public class ProjectManagement : AuditableEntity, IAggregateRoot
{
    public Guid? ProjectStatusId { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    [StringLength(250)]
    public string? MunisAccounts { get; set; }
    [StringLength(500)]
    public string? ProjectNotes { get; set; }
}
