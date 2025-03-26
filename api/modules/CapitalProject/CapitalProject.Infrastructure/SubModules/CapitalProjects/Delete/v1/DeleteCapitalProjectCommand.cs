using MediatR;

namespace budget_request_app.WebApi.CapitalProject.Infrastructure.SubModules.CapitalProjects.Delete.v1;
public sealed record DeleteCapitalProjectCommand(
    Guid Id) : IRequest;
