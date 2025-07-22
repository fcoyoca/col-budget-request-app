using budget_request_app.WebApi.ProjectRequestStatus.Domain;
using budget_request_app.WebApi.ProjectRequestStatus.Exceptions;
using FSH.Framework.Core.Persistence;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.ProjectRequestStatus.Features.Deactivate.v1;
public sealed class DeactivateProjectRequestStatusHandler(
    ILogger<DeactivateProjectRequestStatusHandler> logger,
    [FromKeyedServices("ProjectRequestStatuses")] IRepository<ProjectRequestStatusItem> repository)
    : IRequestHandler<DeactivateProjectRequestStatusCommand, DeactivateProjectRequestStatusResponse>
{
    public async Task<DeactivateProjectRequestStatusResponse> Handle(DeactivateProjectRequestStatusCommand request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        var ProjectRequestStatus = await repository.GetByIdAsync(request.Id, cancellationToken);
        _ = ProjectRequestStatus ?? throw new ProjectRequestStatusItemNotFoundException(request.Id);
        ProjectRequestStatus.IsActive = false;
        await repository.UpdateAsync(ProjectRequestStatus, cancellationToken);
        logger.LogInformation("ProjectRequestStatus item Deactivate {ProjectRequestStatusItemId}", ProjectRequestStatus.Id);
        return new DeactivateProjectRequestStatusResponse(ProjectRequestStatus.Id);
    }
}
