using System.ComponentModel.DataAnnotations;
using budget_request_app.WebApi.CapitalProject.Domain.Events;
using FSH.Framework.Core.Domain;
using FSH.Framework.Core.Domain.Contracts;

namespace budget_request_app.WebApi.CapitalProject.Domain;

public class OperatingRevenue : AuditableEntity, IAggregateRoot
{
    public Guid FundingSourceId { get; set; }
    public Guid DepartmentId { get; set; }
    [StringLength(600)]
    public string? Description { get; set; }
    public decimal Amount { get; set; }
}
