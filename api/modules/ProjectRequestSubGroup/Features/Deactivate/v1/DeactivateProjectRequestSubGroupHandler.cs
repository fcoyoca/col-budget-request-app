using budget_request_app.WebApi.ProjectRequestSubGroup.Domain;
using budget_request_app.WebApi.ProjectRequestSubGroup.Exceptions;
using budget_request_app.WebApi.ProjectRequestSubGroup.Features.Activate.v1;
using FSH.Framework.Core.Persistence;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.ProjectRequestSubGroup.Features.Deactivate.v1;
public sealed class DeactivateProjectRequestSubGroupHandler(
    ILogger<DeactivateProjectRequestSubGroupHandler> logger,
    [FromKeyedServices("ProjectRequestSubGroups")] IRepository<ProjectRequestSubGroupItem> repository)
    : IRequestHandler<DeactivateProjectRequestSubGroupCommand, DeactivateProjectRequestSubGroupResponse>
{
    public async Task<DeactivateProjectRequestSubGroupResponse> Handle(DeactivateProjectRequestSubGroupCommand request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        var ProjectRequestSubGroup = await repository.GetByIdAsync(request.Id, cancellationToken);
        _ = ProjectRequestSubGroup ?? throw new ProjectRequestSubGroupItemNotFoundException(request.Id);
        ProjectRequestSubGroup.IsActive = false;
        await repository.UpdateAsync(ProjectRequestSubGroup, cancellationToken);
        logger.LogInformation("ProjectRequestSubGroup item Deactivate {ProjectRequestSubGroupItemId}", ProjectRequestSubGroup.Id);
        return new DeactivateProjectRequestSubGroupResponse(ProjectRequestSubGroup.Id);
    }
}
