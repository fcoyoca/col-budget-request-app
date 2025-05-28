namespace budget_request_app.WebApi.CapitalProject.Infrastructure.SubModules.CapitalProjects.Get.v1.DTOS;

public class GeneralInformationDTO
{
    public Guid? Id { get; set; }
    public string? ProjectNumber { get; set; }
    public int? RequestId { get; set; }
    public string? RequestStatusId { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public string? RequestingDepartmentIds { get; set; }
    public string? RequestingDepartmentValue { get; set; }
    public string? DepartmentHeadRequestorId { get; set; }
    public string? DepartmentHeadRequestorValue { get; set; }
    public string? RequestTypeId { get; set; }
    public string? RequestTypeValue { get; set; }
    public bool? RequiresTwoThirdsApproval { get; set; } = false;
    public string? RemarksPrintout { get; set; }
    public string? RequestGroupId { get; set; }
    public string? RequestGroupValue { get; set; }
}
