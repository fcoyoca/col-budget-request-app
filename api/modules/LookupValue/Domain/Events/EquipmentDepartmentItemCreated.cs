
using budget_request_app.WebApi.LookupValue.Features.EquipmentDepartments.Create.v1;
using FSH.Framework.Core.Caching;
using FSH.Framework.Core.Domain.Events;
using MediatR;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.LookupValue.Domain.Events;
public record EquipmentDepartmentItemCreated(Guid Id) : DomainEvent;

public class EquipmentDepartmentItemCreatedEventHandler(
    ILogger<EquipmentDepartmentItemCreatedEventHandler> logger,
    ICacheService cache)
    : INotificationHandler<EquipmentDepartmentItemCreated>
{
    public async Task Handle(EquipmentDepartmentItemCreated notification, CancellationToken cancellationToken)
    {
        logger.LogInformation("handling EquipmentDepartment item created domain event..");
        var cacheResponse = new CreateEquipmentDepartmentResponse(
            notification.Id
            );
        await cache.SetAsync($"EquipmentDepartment:{notification.Id}", cacheResponse, cancellationToken: cancellationToken);
    }
}
