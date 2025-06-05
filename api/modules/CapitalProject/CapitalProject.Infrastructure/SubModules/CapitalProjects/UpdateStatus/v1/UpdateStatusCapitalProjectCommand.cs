using MediatR;

namespace budget_request_app.WebApi.CapitalProject.Infrastructure.SubModules.CapitalProjects.UpdateStatus.v1;
public sealed record UpdateStatusCapitalProjectCommand(
    List<Guid> Ids,
    Guid StatusId
    ) : IRequest<UpdateStatusCapitalProjectResponse>;
