using FSH.Framework.Core.Domain;
using FSH.Framework.Core.Domain.Contracts;
using budget_request_app.WebApi.CapitalProject.Domain.Events;

namespace budget_request_app.WebApi.CapitalProject.Domain;

public class CapitalProjectStreetSegment : AuditableEntity, IAggregateRoot
{
    public string StreetId { get; set; }
    public string Description { get; set; }
    public decimal Length { get; set; }
    public string PavementRating { get; set; }
    public string CurbRating { get; set; }
    public string CurbAndGutter { get; set; }
    public string Pave { get; set; }
    public string RightOfWay { get; set; }
    public string SafetyImprovements { get; set; }
    public string UtilityWork { get; set; }
    public string StreetscapingLighting { get; set; }
    public string Sidewalks { get; set; }
    public string OtherWork { get; set; }
}
