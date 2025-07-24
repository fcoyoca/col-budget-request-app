using FSH.Framework.Core.Domain;
using FSH.Framework.Core.Domain.Contracts;
using budget_request_app.WebApi.CapitalProject.Domain.Events;
using System.ComponentModel.DataAnnotations;

namespace budget_request_app.WebApi.CapitalProject.Domain;
public class JustificationPrioritization : AuditableEntity, IAggregateRoot
{
    public int? DepartmentPriorityRanking { get; set; } = 0;
    [StringLength(250)]
    public string? DesiredOutcome { get; set; }
    [StringLength(250)]
    public string? OutcomeMeasurement { get; set; }
    [StringLength(250)]
    public string? BudgetDetermination { get; set; }
    [StringLength(250)]
    public string? SustainabilityGoals { get; set; }
    public decimal? ProjectRankScore { get; set; }
    public int? ProjectScoreYear { get; set; }
}
