
using budget_request_app.WebApi.ProjectBudgetIntroSectionOutlineItem.Features.Create.v1;
using FSH.Framework.Core.Caching;
using FSH.Framework.Core.Domain.Events;
using budget_request_app.WebApi.ProjectBudgetIntroSectionOutlineItem.Features.Get.v1;
using MediatR;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.ProjectBudgetIntroSectionOutlineItem.Domain.Events;
public record ProjectBudgetIntroSectionOutlineItemItemCreated(Guid Id) : DomainEvent;

public class ProjectRequestStatusItemCreatedEventHandler(
    ILogger<ProjectRequestStatusItemCreatedEventHandler> logger,
    ICacheService cache)
    : INotificationHandler<ProjectBudgetIntroSectionOutlineItemItemCreated>
{
    public async Task Handle(ProjectBudgetIntroSectionOutlineItemItemCreated notification, CancellationToken cancellationToken)
    {
        logger.LogInformation("handling ProjectBudgetIntroSectionOutlineItem item created domain event..");
        var cacheResponse = new CreateProjectBudgetIntroSectionOutlineItemResponse(
            notification.Id
            );
        await cache.SetAsync($"ProjectBudgetIntroSectionOutlineItem:{notification.Id}", cacheResponse, cancellationToken: cancellationToken);
    }
}
