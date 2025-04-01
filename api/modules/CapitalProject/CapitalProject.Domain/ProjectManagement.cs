using FSH.Framework.Core.Domain;
using FSH.Framework.Core.Domain.Contracts;
using budget_request_app.WebApi.CapitalProject.Domain.Events;

namespace budget_request_app.WebApi.CapitalProject.Domain;

public class ProjectManagement : AuditableEntity, IAggregateRoot
{
    public Guid? ProjectStatusId { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string? MunisAccounts { get; set; }
    public string? ProjectNotes { get; set; }
}
