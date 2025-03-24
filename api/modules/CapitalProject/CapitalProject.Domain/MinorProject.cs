using FSH.Framework.Core.Domain;
using FSH.Framework.Core.Domain.Contracts;
using budget_request_app.WebApi.CapitalProject.Domain.Events;

namespace budget_request_app.WebApi.CapitalProject.Domain;

public class MinorProject : AuditableEntity, IAggregateRoot
{
    public Guid ExpenditureCategoryId { get; set; }
    public string Description { get; set; }
    public int Year { get; set; }
    public string Location { get; set; }
    public decimal EstimatedCost { get; set; }
}
