
using budget_request_app.WebApi.ProjectExpenditureCategory.Features.Create.v1;
using budget_request_app.WebApi.ProjectExpenditureCategory.Features.Create.v1;
using budget_request_app.WebApi.ProjectExpenditureCategory.Features.Get.v1;
using FSH.Framework.Core.Caching;
using FSH.Framework.Core.Domain.Events;
using MediatR;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.ProjectExpenditureCategory.Domain.Events;
public record ProjectExpenditureCategoryItemUpdated(ProjectExpenditureCategoryItem item) : DomainEvent;

public class ProjectExpenditureCategoryItemUpdatedEventHandler(
    ILogger<ProjectExpenditureCategoryItemUpdatedEventHandler> logger,
    ICacheService cache)
    : INotificationHandler<ProjectExpenditureCategoryItemUpdated>
{
    public async Task Handle(ProjectExpenditureCategoryItemUpdated notification, CancellationToken cancellationToken)
    {
        logger.LogInformation("handling ProjectExpenditureCategory item update domain event..");
        var cacheResponse = new CreateProjectExpenditureCategoryResponse(notification.item.Id);
        await cache.SetAsync($"ProjectExpenditureCategory:{notification.item.Id}", cacheResponse, cancellationToken: cancellationToken);
    }
}
