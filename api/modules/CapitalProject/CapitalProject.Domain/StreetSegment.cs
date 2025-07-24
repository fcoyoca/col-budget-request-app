using FSH.Framework.Core.Domain;
using FSH.Framework.Core.Domain.Contracts;
using budget_request_app.WebApi.CapitalProject.Domain.Events;
using System.ComponentModel.DataAnnotations;

namespace budget_request_app.WebApi.CapitalProject.Domain;

public class StreetSegment : AuditableEntity, IAggregateRoot
{
    [StringLength(160)]
    public string? StreetId { get; set; }
    [StringLength(250)]
    public string? Description { get; set; }
    public decimal Length { get; set; }
    [StringLength(160)]
    public string? PavementRating { get; set; }
    [StringLength(160)]
    public string? CurbRating { get; set; }
    [StringLength(250)]
    public string? CurbAndGutter { get; set; }
    [StringLength(250)]
    public string? Pave { get; set; }
    [StringLength(250)]
    public string? RightOfWay { get; set; }
    [StringLength(250)]
    public string? SafetyImprovements { get; set; }
    [StringLength(250)]
    public string? UtilityWork { get; set; }
    [StringLength(250)]
    public string? StreetscapingLighting { get; set; }
    [StringLength(250)]
    public string? Sidewalks { get; set; }
    [StringLength(250)]
    public string? OtherWork { get; set; }
}
