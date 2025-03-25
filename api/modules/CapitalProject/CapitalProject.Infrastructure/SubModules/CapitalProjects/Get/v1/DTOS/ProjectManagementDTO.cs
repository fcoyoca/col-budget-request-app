namespace budget_request_app.WebApi.CapitalProject.Infrastructure.SubModules.CapitalProjects.Get.v1.DTOS;

public class ProjectManagementDTO
{
    public Guid Id { get; set; }
    public Guid? ProjectStatusId { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string? MunisAccounts { get; set; }
}
