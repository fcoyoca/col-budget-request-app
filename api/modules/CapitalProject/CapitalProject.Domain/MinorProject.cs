using System.ComponentModel.DataAnnotations;
using budget_request_app.WebApi.CapitalProject.Domain.Events;
using FSH.Framework.Core.Domain;
using FSH.Framework.Core.Domain.Contracts;

namespace budget_request_app.WebApi.CapitalProject.Domain;

public class MinorProject : AuditableEntity, IAggregateRoot
{
    public Guid ExpenditureCategoryId { get; set; }
    [StringLength(600)]
    public string? Description { get; set; }
    public int Year { get; set; }
    [StringLength(250)]
    public string? Location { get; set; }
    public decimal EstimatedCost { get; set; } = decimal.Zero;
}
