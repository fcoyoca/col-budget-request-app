using FSH.Framework.Core.Persistence;
using budget_request_app.WebApi.ProjectRequestStatus.Domain;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.ProjectRequestStatus.Features.Create.v1;
public sealed class CreateProjectRequestStatusHandler(
    ILogger<CreateProjectRequestStatusHandler> logger,
    [FromKeyedServices("ProjectRequestStatuses")] IRepository<ProjectRequestStatusItem> repository)
    : IRequestHandler<CreateProjectRequestStatusCommand, CreateProjectRequestStatusResponse>
{
    public async Task<CreateProjectRequestStatusResponse> Handle(CreateProjectRequestStatusCommand request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        var item = ProjectRequestStatusItem.Create(
            request.BudgetId,
            request.SubId,
            request.Title,
            request.IsUnfundedStatus,
            request.LookupValueId
        );

        await repository.AddAsync(item, cancellationToken).ConfigureAwait(false);
        await repository.SaveChangesAsync(cancellationToken).ConfigureAwait(false);
        logger.LogInformation("ProjectRequestStatus item created {ProjectRequestStatusItemId}", item.Id);
        return new CreateProjectRequestStatusResponse(item.Id);
    }
}
