using budget_request_app.WebApi.ProjectRequestStatus.Domain;
using budget_request_app.WebApi.ProjectRequestStatus.Exceptions;
using FSH.Framework.Core.Persistence;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.ProjectRequestStatus.Features.Activate.v1;
public sealed class ActivateProjectRequestStatusHandler(
    ILogger<ActivateProjectRequestStatusHandler> logger,
    [FromKeyedServices("ProjectRequestStatuses")] IRepository<ProjectRequestStatusItem> repository)
    : IRequestHandler<ActivateProjectRequestStatusCommand, ActivateProjectRequestStatusResponse>
{
    public async Task<ActivateProjectRequestStatusResponse> Handle(ActivateProjectRequestStatusCommand request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        var ProjectRequestStatus = await repository.GetByIdAsync(request.Id, cancellationToken);
        _ = ProjectRequestStatus ?? throw new ProjectRequestStatusItemNotFoundException(request.Id.Value);
        ProjectRequestStatus.IsActive = true;
        await repository.UpdateAsync(ProjectRequestStatus, cancellationToken);
        logger.LogInformation("ProjectRequestStatus item Activated {ProjectRequestStatusItemId}", ProjectRequestStatus.Id);
        return new ActivateProjectRequestStatusResponse(ProjectRequestStatus.Id);
    }
}
