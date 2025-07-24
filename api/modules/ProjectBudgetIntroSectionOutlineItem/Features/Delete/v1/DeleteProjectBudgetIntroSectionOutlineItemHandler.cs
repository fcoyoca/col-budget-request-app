using FSH.Framework.Core.Persistence;
using budget_request_app.WebApi.ProjectBudgetIntroSectionOutlineItem.Domain;
using budget_request_app.WebApi.ProjectBudgetIntroSectionOutlineItem.Exceptions;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.ProjectBudgetIntroSectionOutlineItem.Features.Delete.v1;
public sealed class DeleteProjectBudgetIntroSectionOutlineItemHandler(
    ILogger<DeleteProjectBudgetIntroSectionOutlineItemHandler> logger,
    [FromKeyedServices("ProjectBudgetIntroSectionOutlineItems")] IRepository<ProjectBudgetIntroSectionOutlineItemItem> repository)
    : IRequestHandler<DeleteProjectBudgetIntroSectionOutlineItemCommand>
{
    public async Task Handle(DeleteProjectBudgetIntroSectionOutlineItemCommand request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        var ProjectBudgetIntroSectionOutlineItemItem = await repository.GetByIdAsync(request.Id, cancellationToken);
        _ = ProjectBudgetIntroSectionOutlineItemItem ?? throw new ProjectBudgetIntroSectionOutlineItemItemNotFoundException(request.Id);
        await repository.DeleteAsync(ProjectBudgetIntroSectionOutlineItemItem, cancellationToken);
        logger.LogInformation("ProjectBudgetIntroSectionOutlineItem with id : {ProjectBudgetIntroSectionOutlineItemId} deleted", ProjectBudgetIntroSectionOutlineItemItem.Id);
    }
}
