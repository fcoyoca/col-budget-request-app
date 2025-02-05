
using FSH.Framework.Core.Caching;
using FSH.Framework.Core.Domain.Events;
using budget_request_app.WebApi.LookupCategory.Features.Get.v1;
using MediatR;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.LookupCategory.Domain.Events;
public record LookupCategoryItemUpdated(LookupCategoryItem item) : DomainEvent;

public class LookupCategoryItemUpdatedEventHandler(
    ILogger<LookupCategoryItemUpdatedEventHandler> logger,
    ICacheService cache)
    : INotificationHandler<LookupCategoryItemUpdated>
{
    public async Task Handle(LookupCategoryItemUpdated notification, CancellationToken cancellationToken)
    {
        logger.LogInformation("handling LookupCategory item update domain event..");
        var cacheResponse = new GetLookupCategoryResponse(notification.item.Id, notification.item.Name, notification.item.Description);
        await cache.SetAsync($"LookupCategory:{notification.item.Id}", cacheResponse, cancellationToken: cancellationToken);
    }
}
