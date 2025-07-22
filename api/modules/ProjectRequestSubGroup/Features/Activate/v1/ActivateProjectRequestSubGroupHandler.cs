using budget_request_app.WebApi.ProjectRequestSubGroup.Features.Activate.v1;
using budget_request_app.WebApi.ProjectRequestSubGroup.Domain;
using budget_request_app.WebApi.ProjectRequestSubGroup.Exceptions;
using FSH.Framework.Core.Persistence;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.ProjectRequestSubGroup.Features.Activate.v1;
public sealed class ActivateProjectRequestSubGroupHandler(
    ILogger<ActivateProjectRequestSubGroupHandler> logger,
    [FromKeyedServices("ProjectRequestSubGroups")] IRepository<ProjectRequestSubGroupItem> repository)
    : IRequestHandler<ActivateProjectRequestSubGroupCommand, ActivateProjectRequestSubGroupResponse>
{
    public async Task<ActivateProjectRequestSubGroupResponse> Handle(ActivateProjectRequestSubGroupCommand request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        var ProjectRequestSubGroup = await repository.GetByIdAsync(request.Id, cancellationToken);
        _ = ProjectRequestSubGroup ?? throw new ProjectRequestSubGroupItemNotFoundException(request.Id.Value);
        ProjectRequestSubGroup.IsActive = true;
        await repository.UpdateAsync(ProjectRequestSubGroup, cancellationToken);
        logger.LogInformation("ProjectRequestSubGroup item Activated {ProjectRequestSubGroupItemId}", ProjectRequestSubGroup.Id);
        return new ActivateProjectRequestSubGroupResponse(ProjectRequestSubGroup.Id);
    }
}
