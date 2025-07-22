using FSH.Framework.Core.Persistence;
using budget_request_app.WebApi.ProjectRequestStatus.Domain;
using budget_request_app.WebApi.ProjectRequestStatus.Exceptions;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.ProjectRequestStatus.Features.Delete.v1;
public sealed class DeleteProjectRequestStatusHandler(
    ILogger<DeleteProjectRequestStatusHandler> logger,
    [FromKeyedServices("ProjectRequestStatuses")] IRepository<ProjectRequestStatusItem> repository)
    : IRequestHandler<DeleteProjectRequestStatusCommand>
{
    public async Task Handle(DeleteProjectRequestStatusCommand request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        var ProjectRequestStatusItem = await repository.GetByIdAsync(request.Id, cancellationToken);
        _ = ProjectRequestStatusItem ?? throw new ProjectRequestStatusItemNotFoundException(request.Id);
        await repository.DeleteAsync(ProjectRequestStatusItem, cancellationToken);
        logger.LogInformation("ProjectRequestStatus with id : {ProjectRequestStatusId} deleted", ProjectRequestStatusItem.Id);
    }
}
