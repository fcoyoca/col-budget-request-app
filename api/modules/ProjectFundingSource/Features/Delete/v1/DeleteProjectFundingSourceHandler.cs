using FSH.Framework.Core.Persistence;
using budget_request_app.WebApi.ProjectFundingSource.Domain;
using budget_request_app.WebApi.ProjectFundingSource.Exceptions;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.ProjectFundingSource.Features.Delete.v1;
public sealed class DeleteProjectFundingSourceHandler(
    ILogger<DeleteProjectFundingSourceHandler> logger,
    [FromKeyedServices("ProjectFundingSources")] IRepository<ProjectFundingSourceItem> repository)
    : IRequestHandler<DeleteProjectFundingSourceCommand>
{
    public async Task Handle(DeleteProjectFundingSourceCommand request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        var ProjectFundingSourceItem = await repository.GetByIdAsync(request.Id, cancellationToken);
        _ = ProjectFundingSourceItem ?? throw new ProjectFundingSourceItemNotFoundException(request.Id);
        await repository.DeleteAsync(ProjectFundingSourceItem, cancellationToken);
        logger.LogInformation("ProjectFundingSource with id : {ProjectFundingSourceId} deleted", ProjectFundingSourceItem.Id);
    }
}
