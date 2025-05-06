
using budget_request_app.WebApi.LookupValue.Features.Get.v1;
using FSH.Framework.Core.Caching;
using FSH.Framework.Core.Domain.Events;
using MediatR;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.BudgetYear.Domain.Events;
public record BudgetYearItemCreated(Guid Id, int BudgetYear) : DomainEvent;

public class BudgetYearItemCreatedEventHandler(
    ILogger<BudgetYearItemCreatedEventHandler> logger,
    ICacheService cache)
    : INotificationHandler<BudgetYearItemCreated>
{
    public async Task Handle(BudgetYearItemCreated notification, CancellationToken cancellationToken)
    {
        logger.LogInformation("handling BudgetYear item created domain event..");
        var cacheResponse = new GetBudgetYearResponse(notification.Id, notification.BudgetYear);
        await cache.SetAsync($"BudgetYear:{notification.Id}", cacheResponse, cancellationToken: cancellationToken);
    }
}
