
using budget_request_app.WebApi.EquipmentFundingSource.Features.Create.v1;
using FSH.Framework.Core.Caching;
using FSH.Framework.Core.Domain.Events;
using budget_request_app.WebApi.EquipmentFundingSource.Features.Get.v1;
using MediatR;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.EquipmentFundingSource.Domain.Events;
public record EquipmentFundingSourceItemCreated(Guid Id) : DomainEvent;

public class EquipmentFundingSourceItemCreatedEventHandler(
    ILogger<EquipmentFundingSourceItemCreatedEventHandler> logger,
    ICacheService cache)
    : INotificationHandler<EquipmentFundingSourceItemCreated>
{
    public async Task Handle(EquipmentFundingSourceItemCreated notification, CancellationToken cancellationToken)
    {
        logger.LogInformation("handling EquipmentFundingSource item created domain event..");
        var cacheResponse = new CreateEquipmentFundingSourceResponse(
            notification.Id
            );
        await cache.SetAsync($"EquipmentFundingSource:{notification.Id}", cacheResponse, cancellationToken: cancellationToken);
    }
}
