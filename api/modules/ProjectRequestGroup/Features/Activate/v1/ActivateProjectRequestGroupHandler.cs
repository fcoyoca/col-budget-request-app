using budget_request_app.WebApi.ProjectRequestGroup.Features.Activate.v1;
using budget_request_app.WebApi.ProjectRequestGroup.Domain;
using budget_request_app.WebApi.ProjectRequestGroup.Exceptions;
using FSH.Framework.Core.Persistence;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.ProjectRequestGroup.Features.Activate.v1;
public sealed class ActivateProjectRequestGroupHandler(
    ILogger<ActivateProjectRequestGroupHandler> logger,
    [FromKeyedServices("ProjectRequestGroups")] IRepository<ProjectRequestGroupItem> repository)
    : IRequestHandler<ActivateProjectRequestGroupCommand, ActivateProjectRequestGroupResponse>
{
    public async Task<ActivateProjectRequestGroupResponse> Handle(ActivateProjectRequestGroupCommand request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        var ProjectRequestGroup = await repository.GetByIdAsync(request.Id, cancellationToken);
        _ = ProjectRequestGroup ?? throw new ProjectRequestGroupItemNotFoundException(request.Id.Value);
        ProjectRequestGroup.IsActive = true;
        await repository.UpdateAsync(ProjectRequestGroup, cancellationToken);
        logger.LogInformation("ProjectRequestGroup item Activated {ProjectRequestGroupItemId}", ProjectRequestGroup.Id);
        return new ActivateProjectRequestGroupResponse(ProjectRequestGroup.Id);
    }
}
