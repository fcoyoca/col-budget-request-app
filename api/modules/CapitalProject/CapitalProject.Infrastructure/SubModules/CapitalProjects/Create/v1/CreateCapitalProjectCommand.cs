using System.ComponentModel;
using budget_request_app.WebApi.CapitalProject.Domain;
using budget_request_app.WebApi.CapitalProject.Infrastructure.SubModules.CapitalProjects.Get.v1.DTOS;
using MediatR;

namespace budget_request_app.WebApi.CapitalProject.Infrastructure.SubModules.CapitalProjects.Create.v1;

public sealed record CreateCapitalProjectCommand(
    string BudgetId,
    string ProjectNumber,
    string RevisionTitle,
    GeneralInformationDTO? GeneralInformation,
    TimeJustificationApprovalDTO? TimeJustificationApproval,
    OperatingBudgetImpactDTO? OperatingBudgetImpact,
    MinorProjectLocationDTO? MinorProjectLocation,
    FinancialDTO? Financial,
    ProjectManagementDTO? ProjectManagement,
    string? FileIds
) : IRequest<CreateCapitalProjectResponse>;
