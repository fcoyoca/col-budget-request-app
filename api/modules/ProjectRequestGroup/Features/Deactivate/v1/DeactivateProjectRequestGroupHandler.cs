using budget_request_app.WebApi.ProjectRequestGroup.Domain;
using budget_request_app.WebApi.ProjectRequestGroup.Exceptions;
using budget_request_app.WebApi.ProjectRequestGroup.Features.Activate.v1;
using FSH.Framework.Core.Persistence;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.ProjectRequestGroup.Features.Deactivate.v1;
public sealed class DeactivateProjectRequestGroupHandler(
    ILogger<DeactivateProjectRequestGroupHandler> logger,
    [FromKeyedServices("ProjectRequestGroups")] IRepository<ProjectRequestGroupItem> repository)
    : IRequestHandler<DeactivateProjectRequestGroupCommand, DeactivateProjectRequestGroupResponse>
{
    public async Task<DeactivateProjectRequestGroupResponse> Handle(DeactivateProjectRequestGroupCommand request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        var ProjectRequestGroup = await repository.GetByIdAsync(request.Id, cancellationToken);
        _ = ProjectRequestGroup ?? throw new ProjectRequestGroupItemNotFoundException(request.Id);
        ProjectRequestGroup.IsActive = false;
        await repository.UpdateAsync(ProjectRequestGroup, cancellationToken);
        logger.LogInformation("ProjectRequestGroup item Deactivate {ProjectRequestGroupItemId}", ProjectRequestGroup.Id);
        return new DeactivateProjectRequestGroupResponse(ProjectRequestGroup.Id);
    }
}
