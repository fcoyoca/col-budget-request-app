using budget_request_app.WebApi.CapitalProject.Domain;
using budget_request_app.WebApi.CapitalProject.Infrastructure.SubModules.CapitalProjects.Get.v1.DTOS;

//using budget_request_app.WebApi.CapitalProject.Infrastructure.SubModules.CapitalProjects.Create.v1;

namespace budget_request_app.WebApi.CapitalProject.Infrastructure.SubModules.CapitalProjects.Get.v1;
public sealed record GetCapitalProjectResponse(
    Guid Id,
    int RequestNumber,
    string ProjectNumber,
    string? BudgetId,
    string? RevisionTitle,
    int? RequestId,
    GeneralInformationDTO? GeneralInformation,
    TimeJustificationApprovalDTO? TimeJustificationApproval,
    OperatingBudgetImpactDTO? OperatingBudgetImpact,
    MinorProjectLocationDTO? MinorProjectLocation,
    FinancialDTO? Financial,
    ProjectManagementDTO? ProjectManagement,
    List<ProjectAttachmentDTO>? Attachments,
    string? ImageFileUrl
    );

public class ProjectAttachmentDTO
{
    public string Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public double Size { get; set; }
    public string Type { get; set; } = string.Empty;
    public string FileName { get; set; } = string.Empty;
}

public class ProjectImageFileDTO
{
    public string? ImageFile { get; set; } = string.Empty;
    public string? ImageFileExt { get; set; } = string.Empty;
    public string? ImageFileName { get; set; } = string.Empty;
    public string? ImageFilePath { get; set; } = string.Empty;
}
