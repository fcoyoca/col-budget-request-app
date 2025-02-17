
using FSH.Framework.Core.Caching;
using FSH.Framework.Core.Domain.Events;
using budget_request_app.WebApi.LookupValue.Features.Get.v1;
using MediatR;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.LookupValue.Domain.Events;
public record LookupValueItemCreated(Guid Id, string name, Guid? lookupCategoryId, bool? isActive) : DomainEvent;

public class LookupValueItemCreatedEventHandler(
    ILogger<LookupValueItemCreatedEventHandler> logger,
    ICacheService cache)
    : INotificationHandler<LookupValueItemCreated>
{
    public async Task Handle(LookupValueItemCreated notification, CancellationToken cancellationToken)
    {
        logger.LogInformation("handling LookupValue item created domain event..");
        var cacheResponse = new GetLookupValueResponse(notification.Id, notification.name, notification.lookupCategoryId, notification.isActive);
        await cache.SetAsync($"LookupValue:{notification.Id}", cacheResponse, cancellationToken: cancellationToken);
    }
}
