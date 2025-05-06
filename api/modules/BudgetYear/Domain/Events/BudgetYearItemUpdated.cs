
using budget_request_app.WebApi.LookupValue.Features.Get.v1;
using FSH.Framework.Core.Caching;
using FSH.Framework.Core.Domain.Events;
using MediatR;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.BudgetYear.Domain.Events;
public record BudgetYearItemUpdated(BudgetYearItem item) : DomainEvent;

public class BudgetYearItemUpdatedEventHandler(
    ILogger<BudgetYearItemUpdatedEventHandler> logger,
    ICacheService cache)
    : INotificationHandler<BudgetYearItemUpdated>
{
    public async Task Handle(BudgetYearItemUpdated notification, CancellationToken cancellationToken)
    {
        logger.LogInformation("handling BudgetYear item update domain event..");
        var cacheResponse = new GetBudgetYearResponse(notification.item.Id, notification.item.BudgetYear);
        await cache.SetAsync($"BudgetYear:{notification.item.Id}", cacheResponse, cancellationToken: cancellationToken);
    }
}
