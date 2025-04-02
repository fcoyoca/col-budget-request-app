using budget_request_app.WebApi.CapitalProject.Domain;
using budget_request_app.WebApi.CapitalProject.Infrastructure.SubModules.CapitalProjects.Get.v1.DTOS;

//using budget_request_app.WebApi.CapitalProject.Infrastructure.SubModules.CapitalProjects.Create.v1;

namespace budget_request_app.WebApi.CapitalProject.Infrastructure.SubModules.CapitalProjects.Get.v1;
public sealed record SearchCapitalProjectResponse(
    Guid Id,
    string? Title,
    string? RequestingDepartment,
    string? DepartmentHeadRequestor,
    string? RequestStatus,
    string? DepartmentPriorityRanking
    );
