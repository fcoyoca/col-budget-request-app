
using budget_request_app.WebApi.ProjectFundingSource.Features.Create.v1;
using FSH.Framework.Core.Caching;
using FSH.Framework.Core.Domain.Events;
using budget_request_app.WebApi.ProjectFundingSource.Features.Get.v1;
using MediatR;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.ProjectFundingSource.Domain.Events;
public record ProjectFundingSourceItemUpdated(ProjectFundingSourceItem item) : DomainEvent;

public class ProjectFundingSourceItemUpdatedEventHandler(
    ILogger<ProjectFundingSourceItemUpdatedEventHandler> logger,
    ICacheService cache)
    : INotificationHandler<ProjectFundingSourceItemUpdated>
{
    public async Task Handle(ProjectFundingSourceItemUpdated notification, CancellationToken cancellationToken)
    {
        logger.LogInformation("handling ProjectFundingSource item update domain event..");
        var cacheResponse = new CreateProjectFundingSourceResponse(notification.item.Id);
        await cache.SetAsync($"ProjectFundingSource:{notification.item.Id}", cacheResponse, cancellationToken: cancellationToken);
    }
}
