
using budget_request_app.WebApi.ProjectBudgetIntroSectionOutlineItem.Features.Create.v1;
using budget_request_app.WebApi.ProjectBudgetIntroSectionOutlineItem.Features.Create.v1;
using budget_request_app.WebApi.ProjectBudgetIntroSectionOutlineItem.Features.Get.v1;
using FSH.Framework.Core.Caching;
using FSH.Framework.Core.Domain.Events;
using MediatR;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.ProjectBudgetIntroSectionOutlineItem.Domain.Events;
public record ProjectBudgetIntroSectionOutlineItemItemUpdated(ProjectBudgetIntroSectionOutlineItemItem item) : DomainEvent;

public class ProjectRequestStatusItemUpdatedEventHandler(
    ILogger<ProjectRequestStatusItemUpdatedEventHandler> logger,
    ICacheService cache)
    : INotificationHandler<ProjectBudgetIntroSectionOutlineItemItemUpdated>
{
    public async Task Handle(ProjectBudgetIntroSectionOutlineItemItemUpdated notification, CancellationToken cancellationToken)
    {
        logger.LogInformation("handling ProjectBudgetIntroSectionOutlineItem item update domain event..");
        var cacheResponse = new CreateProjectBudgetIntroSectionOutlineItemResponse(notification.item.Id);
        await cache.SetAsync($"ProjectBudgetIntroSectionOutlineItem:{notification.item.Id}", cacheResponse, cancellationToken: cancellationToken);
    }
}
