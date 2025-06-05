using System.ComponentModel;
using budget_request_app.WebApi.CapitalProject.Domain;
using budget_request_app.WebApi.CapitalProject.Infrastructure.SubModules.CapitalProjects.Get.v1;
using budget_request_app.WebApi.CapitalProject.Infrastructure.SubModules.CapitalProjects.Get.v1.DTOS;
using MediatR;

namespace budget_request_app.WebApi.CapitalProject.Infrastructure.SubModules.CapitalProjects.GetProjectNumber.v1;

public sealed record GetProjectNumberCapitalProjectRequest(
) : IRequest<GetProjectNumberCapitalProjectResponse>;
