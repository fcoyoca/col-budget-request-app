
using FSH.Framework.Core.Caching;
using FSH.Framework.Core.Domain.Events;
using budget_request_app.WebApi.LookupCategory.Features.Get.v1;
using MediatR;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.LookupCategory.Domain.Events;
public record LookupCategoryItemCreated(Guid Id, string name, string description, int moduleId) : DomainEvent;

public class LookupCategoryItemCreatedEventHandler(
    ILogger<LookupCategoryItemCreatedEventHandler> logger,
    ICacheService cache)
    : INotificationHandler<LookupCategoryItemCreated>
{
    public async Task Handle(LookupCategoryItemCreated notification, CancellationToken cancellationToken)
    {
        logger.LogInformation("handling LookupCategory item created domain event..");
        var cacheResponse = new GetLookupCategoryResponse(notification.Id, notification.name, notification.description, notification.moduleId);
        await cache.SetAsync($"LookupCategory:{notification.Id}", cacheResponse, cancellationToken: cancellationToken);
    }
}
