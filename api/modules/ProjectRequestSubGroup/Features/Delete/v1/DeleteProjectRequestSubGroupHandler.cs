using FSH.Framework.Core.Persistence;
using budget_request_app.WebApi.ProjectRequestSubGroup.Domain;
using budget_request_app.WebApi.ProjectRequestSubGroup.Exceptions;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.ProjectRequestSubGroup.Features.Delete.v1;
public sealed class DeleteProjectRequestSubGroupHandler(
    ILogger<DeleteProjectRequestSubGroupHandler> logger,
    [FromKeyedServices("ProjectRequestSubGroups")] IRepository<ProjectRequestSubGroupItem> repository)
    : IRequestHandler<DeleteProjectRequestSubGroupCommand>
{
    public async Task Handle(DeleteProjectRequestSubGroupCommand request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        var ProjectRequestSubGroupItem = await repository.GetByIdAsync(request.Id, cancellationToken);
        _ = ProjectRequestSubGroupItem ?? throw new ProjectRequestSubGroupItemNotFoundException(request.Id);
        await repository.DeleteAsync(ProjectRequestSubGroupItem, cancellationToken);
        logger.LogInformation("ProjectRequestSubGroup with id : {ProjectRequestSubGroupId} deleted", ProjectRequestSubGroupItem.Id);
    }
}
