
using budget_request_app.WebApi.ProjectRequestStatus.Features.Create.v1;
using budget_request_app.WebApi.ProjectRequestStatus.Features.Create.v1;
using budget_request_app.WebApi.ProjectRequestStatus.Features.Get.v1;
using FSH.Framework.Core.Caching;
using FSH.Framework.Core.Domain.Events;
using MediatR;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.ProjectRequestStatus.Domain.Events;
public record ProjectRequestStatusItemUpdated(ProjectRequestStatusItem item) : DomainEvent;

public class ProjectRequestStatusItemUpdatedEventHandler(
    ILogger<ProjectRequestStatusItemUpdatedEventHandler> logger,
    ICacheService cache)
    : INotificationHandler<ProjectRequestStatusItemUpdated>
{
    public async Task Handle(ProjectRequestStatusItemUpdated notification, CancellationToken cancellationToken)
    {
        logger.LogInformation("handling ProjectRequestStatus item update domain event..");
        var cacheResponse = new CreateProjectRequestStatusResponse(notification.item.Id);
        await cache.SetAsync($"ProjectRequestStatus:{notification.item.Id}", cacheResponse, cancellationToken: cancellationToken);
    }
}
