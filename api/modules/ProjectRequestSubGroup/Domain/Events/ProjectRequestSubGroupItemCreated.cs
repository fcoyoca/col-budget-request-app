
using budget_request_app.WebApi.ProjectRequestSubGroup.Features.Create.v1;
using FSH.Framework.Core.Caching;
using FSH.Framework.Core.Domain.Events;
using budget_request_app.WebApi.ProjectRequestSubGroup.Features.Get.v1;
using MediatR;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.ProjectRequestSubGroup.Domain.Events;
public record ProjectRequestSubGroupItemCreated(Guid Id) : DomainEvent;

public class ProjectRequestGroupItemCreatedEventHandler(
    ILogger<ProjectRequestGroupItemCreatedEventHandler> logger,
    ICacheService cache)
    : INotificationHandler<ProjectRequestSubGroupItemCreated>
{
    public async Task Handle(ProjectRequestSubGroupItemCreated notification, CancellationToken cancellationToken)
    {
        logger.LogInformation("handling ProjectRequestSubGroup item created domain event..");
        var cacheResponse = new CreateProjectRequestSubGroupResponse(
            notification.Id
            );
        await cache.SetAsync($"ProjectRequestSubGroup:{notification.Id}", cacheResponse, cancellationToken: cancellationToken);
    }
}
