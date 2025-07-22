
using budget_request_app.WebApi.ProjectRequestStatus.Features.Create.v1;
using FSH.Framework.Core.Caching;
using FSH.Framework.Core.Domain.Events;
using budget_request_app.WebApi.ProjectRequestStatus.Features.Get.v1;
using MediatR;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.ProjectRequestStatus.Domain.Events;
public record ProjectRequestStatusItemCreated(Guid Id) : DomainEvent;

public class ProjectRequestStatusItemCreatedEventHandler(
    ILogger<ProjectRequestStatusItemCreatedEventHandler> logger,
    ICacheService cache)
    : INotificationHandler<ProjectRequestStatusItemCreated>
{
    public async Task Handle(ProjectRequestStatusItemCreated notification, CancellationToken cancellationToken)
    {
        logger.LogInformation("handling ProjectRequestStatus item created domain event..");
        var cacheResponse = new CreateProjectRequestStatusResponse(
            notification.Id
            );
        await cache.SetAsync($"ProjectRequestStatus:{notification.Id}", cacheResponse, cancellationToken: cancellationToken);
    }
}
