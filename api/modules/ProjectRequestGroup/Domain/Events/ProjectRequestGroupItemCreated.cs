
using budget_request_app.WebApi.ProjectRequestGroup.Features.Create.v1;
using FSH.Framework.Core.Caching;
using FSH.Framework.Core.Domain.Events;
using budget_request_app.WebApi.ProjectRequestGroup.Features.Get.v1;
using MediatR;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.ProjectRequestGroup.Domain.Events;
public record ProjectRequestGroupItemCreated(Guid Id) : DomainEvent;

public class ProjectRequestGroupItemCreatedEventHandler(
    ILogger<ProjectRequestGroupItemCreatedEventHandler> logger,
    ICacheService cache)
    : INotificationHandler<ProjectRequestGroupItemCreated>
{
    public async Task Handle(ProjectRequestGroupItemCreated notification, CancellationToken cancellationToken)
    {
        logger.LogInformation("handling ProjectRequestGroup item created domain event..");
        var cacheResponse = new CreateProjectRequestGroupResponse(
            notification.Id
            );
        await cache.SetAsync($"ProjectRequestGroup:{notification.Id}", cacheResponse, cancellationToken: cancellationToken);
    }
}
