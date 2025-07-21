
using budget_request_app.WebApi.ProjectRequestGroup.Features.Create.v1;
using budget_request_app.WebApi.ProjectRequestGroup.Features.Create.v1;
using budget_request_app.WebApi.ProjectRequestGroup.Features.Get.v1;
using FSH.Framework.Core.Caching;
using FSH.Framework.Core.Domain.Events;
using MediatR;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.ProjectRequestGroup.Domain.Events;
public record ProjectRequestGroupItemUpdated(ProjectRequestGroupItem item) : DomainEvent;

public class ProjectRequestGroupItemUpdatedEventHandler(
    ILogger<ProjectRequestGroupItemUpdatedEventHandler> logger,
    ICacheService cache)
    : INotificationHandler<ProjectRequestGroupItemUpdated>
{
    public async Task Handle(ProjectRequestGroupItemUpdated notification, CancellationToken cancellationToken)
    {
        logger.LogInformation("handling ProjectRequestGroup item update domain event..");
        var cacheResponse = new CreateProjectRequestGroupResponse(notification.item.Id);
        await cache.SetAsync($"ProjectRequestGroup:{notification.item.Id}", cacheResponse, cancellationToken: cancellationToken);
    }
}
