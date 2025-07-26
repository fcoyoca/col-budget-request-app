
using budget_request_app.WebApi.LookupValue.Features.LookupValues.Get.v1;
using FSH.Framework.Core.Caching;
using FSH.Framework.Core.Domain.Events;
using MediatR;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.LookupValue.Domain.Events;
public record LookupValueItemUpdated(LookupValueItem item) : DomainEvent;

public class LookupValueItemUpdatedEventHandler(
    ILogger<LookupValueItemUpdatedEventHandler> logger,
    ICacheService cache)
    : INotificationHandler<LookupValueItemUpdated>
{
    public async Task Handle(LookupValueItemUpdated notification, CancellationToken cancellationToken)
    {
        logger.LogInformation("handling LookupValue item update domain event..");
        var cacheResponse = new GetLookupValueResponse(notification.item.Id, notification.item.Name, notification.item.LookupCategoryId, notification.item.IsActive);
        await cache.SetAsync($"LookupValue:{notification.item.Id}", cacheResponse, cancellationToken: cancellationToken);
    }
}
