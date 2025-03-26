using budget_request_app.WebApi.CapitalProject.Domain;
using budget_request_app.WebApi.CapitalProject.Domain.Exceptions;
using budget_request_app.WebApi.CapitalProject.Infrastructure.SubModules.CapitalProjects.Delete.v1;
using FSH.Framework.Core.Persistence;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.Catalog.Application.CapitalProjects.Delete.v1;
public sealed class DeleteCapitalProjectHandler(
    ILogger<DeleteCapitalProjectHandler> logger,
    [FromKeyedServices("capitalProjects")] IRepository<CapitalProjectItem> repository)
    : IRequestHandler<DeleteCapitalProjectCommand>
{
    public async Task Handle(DeleteCapitalProjectCommand request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        var capitalEquipment = await repository.GetByIdAsync(request.Id, cancellationToken);
        _ = capitalEquipment ?? throw new CapitalProjectNotFoundException(request.Id);
        await repository.DeleteAsync(capitalEquipment, cancellationToken);
        logger.LogInformation("capitalEquipment with id : {CapitalProjectId} deleted", capitalEquipment.Id);
    }
}
