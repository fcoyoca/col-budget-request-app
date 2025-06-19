using FSH.Framework.Core.Persistence;
using budget_request_app.WebApi.ProjectFundingSource.Domain;
using budget_request_app.WebApi.ProjectFundingSource.Exceptions;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.ProjectFundingSource.Features.Activate.v1;
public sealed class ActivateProjectFundingSourceHandler(
    ILogger<ActivateProjectFundingSourceHandler> logger,
    [FromKeyedServices("ProjectFundingSources")] IRepository<ProjectFundingSourceItem> repository)
    : IRequestHandler<ActivateProjectFundingSourceCommand, ActivateProjectFundingSourceResponse>
{
    public async Task<ActivateProjectFundingSourceResponse> Handle(ActivateProjectFundingSourceCommand request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        var ProjectFundingSource = await repository.GetByIdAsync(request.Id, cancellationToken);
        _ = ProjectFundingSource ?? throw new ProjectFundingSourceItemNotFoundException(request.Id.Value);
        ProjectFundingSource.IsActive = true;
        await repository.UpdateAsync(ProjectFundingSource, cancellationToken);
        logger.LogInformation("ProjectFundingSource item Activated {ProjectFundingSourceItemId}", ProjectFundingSource.Id);
        return new ActivateProjectFundingSourceResponse(ProjectFundingSource.Id);
    }
}
