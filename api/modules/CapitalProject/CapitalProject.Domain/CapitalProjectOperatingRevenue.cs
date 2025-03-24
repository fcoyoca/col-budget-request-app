using FSH.Framework.Core.Domain;
using FSH.Framework.Core.Domain.Contracts;
using budget_request_app.WebApi.CapitalProject.Domain.Events;

namespace budget_request_app.WebApi.CapitalProject.Domain;

public class CapitalProjectOperatingRevenue : AuditableEntity, IAggregateRoot
{
    public Guid FundingSourceId { get; set; }
    public Guid DepartmentId { get; set; }
    public string Description { get; set; }
    public decimal Amount { get; set; }
}
