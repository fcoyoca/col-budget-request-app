
using budget_request_app.WebApi.EquipmentFundingSource.Features.Create.v1;
using budget_request_app.WebApi.EquipmentFundingSource.Features.Create.v1;
using budget_request_app.WebApi.EquipmentFundingSource.Features.Get.v1;
using FSH.Framework.Core.Caching;
using FSH.Framework.Core.Domain.Events;
using MediatR;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.EquipmentFundingSource.Domain.Events;
public record EquipmentFundingSourceItemUpdated(EquipmentFundingSourceItem item) : DomainEvent;

public class EquipmentFundingSourceItemUpdatedEventHandler(
    ILogger<EquipmentFundingSourceItemUpdatedEventHandler> logger,
    ICacheService cache)
    : INotificationHandler<EquipmentFundingSourceItemUpdated>
{
    public async Task Handle(EquipmentFundingSourceItemUpdated notification, CancellationToken cancellationToken)
    {
        logger.LogInformation("handling EquipmentFundingSource item update domain event..");
        var cacheResponse = new CreateEquipmentFundingSourceResponse(notification.item.Id);
        await cache.SetAsync($"EquipmentFundingSource:{notification.item.Id}", cacheResponse, cancellationToken: cancellationToken);
    }
}
