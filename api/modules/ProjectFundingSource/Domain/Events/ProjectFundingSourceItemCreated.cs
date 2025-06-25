
using budget_request_app.WebApi.ProjectFundingSource.Features.Create.v1;
using FSH.Framework.Core.Caching;
using FSH.Framework.Core.Domain.Events;
using budget_request_app.WebApi.ProjectFundingSource.Features.Get.v1;
using MediatR;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.ProjectFundingSource.Domain.Events;
public record ProjectFundingSourceItemCreated(Guid Id) : DomainEvent;

public class ProjectFundingSourceItemCreatedEventHandler(
    ILogger<ProjectFundingSourceItemCreatedEventHandler> logger,
    ICacheService cache)
    : INotificationHandler<ProjectFundingSourceItemCreated>
{
    public async Task Handle(ProjectFundingSourceItemCreated notification, CancellationToken cancellationToken)
    {
        logger.LogInformation("handling ProjectFundingSource item created domain event..");
        var cacheResponse = new CreateProjectFundingSourceResponse(
            notification.Id
            );
        await cache.SetAsync($"ProjectFundingSource:{notification.Id}", cacheResponse, cancellationToken: cancellationToken);
    }
}
