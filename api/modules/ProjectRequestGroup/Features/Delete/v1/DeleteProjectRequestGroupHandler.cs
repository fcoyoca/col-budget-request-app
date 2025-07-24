using FSH.Framework.Core.Persistence;
using budget_request_app.WebApi.ProjectRequestGroup.Domain;
using budget_request_app.WebApi.ProjectRequestGroup.Exceptions;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.ProjectRequestGroup.Features.Delete.v1;
public sealed class DeleteProjectRequestGroupHandler(
    ILogger<DeleteProjectRequestGroupHandler> logger,
    [FromKeyedServices("ProjectRequestGroups")] IRepository<ProjectRequestGroupItem> repository)
    : IRequestHandler<DeleteProjectRequestGroupCommand>
{
    public async Task Handle(DeleteProjectRequestGroupCommand request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        var ProjectRequestGroupItem = await repository.GetByIdAsync(request.Id, cancellationToken);
        _ = ProjectRequestGroupItem ?? throw new ProjectRequestGroupItemNotFoundException(request.Id);
        await repository.DeleteAsync(ProjectRequestGroupItem, cancellationToken);
        logger.LogInformation("ProjectRequestGroup with id : {ProjectRequestGroupId} deleted", ProjectRequestGroupItem.Id);
    }
}
