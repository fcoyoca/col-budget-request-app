using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using budget_request_app.WebApi.CapitalEquipment.Domain.Events;
using FSH.Framework.Core.Domain;
using FSH.Framework.Core.Domain.Contracts;

namespace budget_request_app.WebApi.CapitalEquipment.Domain;
public class PastFunding : AuditableEntity, IAggregateRoot
{
    public string? Details { get; set; }
    public int? Year  { get; set; }
    public decimal? Amount { get; set; }
    public string? Request { get; set; }
    public Guid? FundingSource { get; set; } = Guid.Empty;
    public Guid? FundingSubSource { get; set; } = Guid.Empty;
    public string? SOF  { get; set; }
}
