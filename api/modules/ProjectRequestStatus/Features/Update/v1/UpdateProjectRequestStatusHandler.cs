using FSH.Framework.Core.Persistence;
using budget_request_app.WebApi.ProjectRequestStatus.Domain;
using budget_request_app.WebApi.ProjectRequestStatus.Exceptions;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.ProjectRequestStatus.Features.Update.v1;

public sealed class UpdateProjectRequestStatusHandler(
    ILogger<UpdateProjectRequestStatusHandler> logger,
    [FromKeyedServices("ProjectRequestStatuses")] IRepository<ProjectRequestStatusItem> repository)
    : IRequestHandler<UpdateProjectRequestStatusCommand, UpdateProjectRequestStatusResponse>
{
    public async Task<UpdateProjectRequestStatusResponse> Handle(UpdateProjectRequestStatusCommand request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);

        var projectRequestStatus = await repository.GetByIdAsync(request.Id, cancellationToken);
        _ = projectRequestStatus ?? throw new ProjectRequestStatusItemNotFoundException(request.Id);

        // Update properties
        projectRequestStatus.BudgetId = request.BudgetId;
        projectRequestStatus.SubId = request.SubId;
        projectRequestStatus.Title = request.Title;
        projectRequestStatus.IsUnfundedStatus = request.IsUnfundedStatus;
        await repository.UpdateAsync(projectRequestStatus, cancellationToken);

        logger.LogInformation("ProjectRequestStatus item updated: {ProjectRequestStatusItemId}", projectRequestStatus.Id);

        return new UpdateProjectRequestStatusResponse(projectRequestStatus.Id);
    }
}
