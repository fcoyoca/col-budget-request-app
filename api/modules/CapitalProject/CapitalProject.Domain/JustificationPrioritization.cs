using FSH.Framework.Core.Domain;
using FSH.Framework.Core.Domain.Contracts;
using budget_request_app.WebApi.CapitalProject.Domain.Events;

namespace budget_request_app.WebApi.CapitalProject.Domain;
public class JustificationPrioritization : AuditableEntity, IAggregateRoot
{
    public int? DepartmentPriorityRanking { get; set; } = 0;
    public string? DesiredOutcome { get; set; }
    public string? OutcomeMeasurement { get; set; }
    public string? BudgetDetermination { get; set; }
    public string? SustainabilityGoals { get; set; }
}
