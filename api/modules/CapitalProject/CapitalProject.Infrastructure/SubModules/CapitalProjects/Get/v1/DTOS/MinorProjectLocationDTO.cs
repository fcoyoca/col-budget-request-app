namespace budget_request_app.WebApi.CapitalProject.Infrastructure.SubModules.CapitalProjects.Get.v1.DTOS;

public class MinorProjectLocationDTO
{
    public RequestLocationDTO? RequestLocation { get; set; }
    public List<MinorProjectDTO>? MinorProjects { get; set; }
    public List<StreetSegmentDTO>? StreetSegments { get; set; }
}

public class RequestLocationDTO
{
    public bool? IsMappedRequest { get; set; } = false;
    public string? GISMappingDescription { get; set; }
}

public class MinorProjectDTO
{
    public Guid Id { get; set; }
    public Guid ExpenditureCategoryId { get; set; }
    public string Description { get; set; }
    public int Year { get; set; }
    public string Location { get; set; }
    public decimal EstimatedCost { get; set; }
}

public class StreetSegmentDTO
{
    public Guid Id { get; set; }
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
