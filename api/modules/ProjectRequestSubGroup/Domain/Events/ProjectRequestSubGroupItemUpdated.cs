
using budget_request_app.WebApi.ProjectRequestSubGroup.Features.Create.v1;
using budget_request_app.WebApi.ProjectRequestSubGroup.Features.Create.v1;
using budget_request_app.WebApi.ProjectRequestSubGroup.Features.Get.v1;
using FSH.Framework.Core.Caching;
using FSH.Framework.Core.Domain.Events;
using MediatR;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.ProjectRequestSubGroup.Domain.Events;
public record ProjectRequestSubGroupItemUpdated(ProjectRequestSubGroupItem item) : DomainEvent;

public class ProjectRequestGroupItemUpdatedEventHandler(
    ILogger<ProjectRequestGroupItemUpdatedEventHandler> logger,
    ICacheService cache)
    : INotificationHandler<ProjectRequestSubGroupItemUpdated>
{
    public async Task Handle(ProjectRequestSubGroupItemUpdated notification, CancellationToken cancellationToken)
    {
        logger.LogInformation("handling ProjectRequestSubGroup item update domain event..");
        var cacheResponse = new CreateProjectRequestSubGroupResponse(notification.item.Id);
        await cache.SetAsync($"ProjectRequestSubGroup:{notification.item.Id}", cacheResponse, cancellationToken: cancellationToken);
    }
}
