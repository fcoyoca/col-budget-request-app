using FSH.Framework.Core.Persistence;
using budget_request_app.WebApi.ProjectFundingSource.Domain;
using budget_request_app.WebApi.ProjectFundingSource.Exceptions;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.ProjectFundingSource.Features.Deactivate.v1;
public sealed class DeactivateProjectFundingSourceHandler(
    ILogger<DeactivateProjectFundingSourceHandler> logger,
    [FromKeyedServices("ProjectFundingSources")] IRepository<ProjectFundingSourceItem> repository)
    : IRequestHandler<DeactivateProjectFundingSourceCommand, DeactivateProjectFundingSourceResponse>
{
    public async Task<DeactivateProjectFundingSourceResponse> Handle(DeactivateProjectFundingSourceCommand request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        var ProjectFundingSource = await repository.GetByIdAsync(request.Id, cancellationToken);
        _ = ProjectFundingSource ?? throw new ProjectFundingSourceItemNotFoundException(request.Id);
        ProjectFundingSource.IsActive = false;
        await repository.UpdateAsync(ProjectFundingSource, cancellationToken);
        logger.LogInformation("ProjectFundingSource item Deactivate {ProjectFundingSourceItemId}", ProjectFundingSource.Id);
        return new DeactivateProjectFundingSourceResponse(ProjectFundingSource.Id);
    }
}
