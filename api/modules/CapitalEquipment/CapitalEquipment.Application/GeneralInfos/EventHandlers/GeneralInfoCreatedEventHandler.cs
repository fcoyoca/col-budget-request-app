using budget_request_app.WebApi.CapitalEquipment.Domain.Events;
using MediatR;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.CapitalEquipment.Application.GeneralInfos.EventHandlers;

public class GeneralInfoCreatedEventHandler(ILogger<GeneralInfoCreatedEventHandler> logger) : INotificationHandler<GeneralInfoCreated>
{
    public async Task Handle(GeneralInfoCreated notification,
        CancellationToken cancellationToken)
    {
        logger.LogInformation("handling GeneralInfo created domain event..");
        await Task.FromResult(notification);
        logger.LogInformation("finished handling GeneralInfo created domain event..");
    }
}

