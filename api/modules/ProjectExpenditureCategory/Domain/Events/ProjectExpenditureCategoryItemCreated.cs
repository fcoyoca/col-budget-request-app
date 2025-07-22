
using budget_request_app.WebApi.ProjectExpenditureCategory.Features.Create.v1;
using FSH.Framework.Core.Caching;
using FSH.Framework.Core.Domain.Events;
using budget_request_app.WebApi.ProjectExpenditureCategory.Features.Get.v1;
using MediatR;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.ProjectExpenditureCategory.Domain.Events;
public record ProjectExpenditureCategoryItemCreated(Guid Id) : DomainEvent;

public class ProjectExpenditureCategoryItemCreatedEventHandler(
    ILogger<ProjectExpenditureCategoryItemCreatedEventHandler> logger,
    ICacheService cache)
    : INotificationHandler<ProjectExpenditureCategoryItemCreated>
{
    public async Task Handle(ProjectExpenditureCategoryItemCreated notification, CancellationToken cancellationToken)
    {
        logger.LogInformation("handling ProjectExpenditureCategory item created domain event..");
        var cacheResponse = new CreateProjectExpenditureCategoryResponse(
            notification.Id
            );
        await cache.SetAsync($"ProjectExpenditureCategory:{notification.Id}", cacheResponse, cancellationToken: cancellationToken);
    }
}
