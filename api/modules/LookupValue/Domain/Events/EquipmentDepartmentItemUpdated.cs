using budget_request_app.WebApi.LookupValue.Features.EquipmentDepartments.Create.v1;
using FSH.Framework.Core.Caching;
using FSH.Framework.Core.Domain.Events;
using MediatR;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.LookupValue.Domain.Events;
public record EquipmentDepartmentItemUpdated(EquipmentDepartmentItem item) : DomainEvent;

public class EquipmentDepartmentItemUpdatedEventHandler(
    ILogger<EquipmentDepartmentItemUpdatedEventHandler> logger,
    ICacheService cache)
    : INotificationHandler<EquipmentDepartmentItemUpdated>
{
    public async Task Handle(EquipmentDepartmentItemUpdated notification, CancellationToken cancellationToken)
    {
        logger.LogInformation("handling EquipmentDepartment item update domain event..");
        var cacheResponse = new CreateEquipmentDepartmentResponse(notification.item.Id);
        await cache.SetAsync($"EquipmentDepartment:{notification.item.Id}", cacheResponse, cancellationToken: cancellationToken);
    }
}
