using budget_request_app.WebApi.CapitalEquipment.Domain.Events;
using MediatR;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.CapitalEquipment.Infrastructure.SubModules.CapitalEquipments.EventHandlers;

public class CapitalEquipmentCreatedEventHandler(ILogger<CapitalEquipmentCreatedEventHandler> logger) : INotificationHandler<CapitalEquipmentCreated>
{
    public async Task Handle(CapitalEquipmentCreated notification,
        CancellationToken cancellationToken)
    {
        logger.LogInformation("handling CapitalEquipment created domain event..");
        await Task.FromResult(notification);
        logger.LogInformation("finished handling CapitalEquipment created domain event..");
    }
}

