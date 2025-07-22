using budget_request_app.WebApi.ProjectBudgetIntroSectionOutlineItem.Domain;
using budget_request_app.WebApi.ProjectBudgetIntroSectionOutlineItem.Exceptions;
using FSH.Framework.Core.Persistence;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.ProjectBudgetIntroSectionOutlineItem.Features.Deactivate.v1;
public sealed class DeactivateProjectBudgetIntroSectionOutlineItemHandler(
    ILogger<DeactivateProjectBudgetIntroSectionOutlineItemHandler> logger,
    [FromKeyedServices("ProjectBudgetIntroSectionOutlineItems")] IRepository<ProjectBudgetIntroSectionOutlineItemItem> repository)
    : IRequestHandler<DeactivateProjectBudgetIntroSectionOutlineItemCommand, DeactivateProjectBudgetIntroSectionOutlineItemResponse>
{
    public async Task<DeactivateProjectBudgetIntroSectionOutlineItemResponse> Handle(DeactivateProjectBudgetIntroSectionOutlineItemCommand request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        var ProjectBudgetIntroSectionOutlineItem = await repository.GetByIdAsync(request.Id, cancellationToken);
        _ = ProjectBudgetIntroSectionOutlineItem ?? throw new ProjectBudgetIntroSectionOutlineItemItemNotFoundException(request.Id);
        ProjectBudgetIntroSectionOutlineItem.IsActive = false;
        await repository.UpdateAsync(ProjectBudgetIntroSectionOutlineItem, cancellationToken);
        logger.LogInformation("ProjectBudgetIntroSectionOutlineItem item Deactivate {ProjectBudgetIntroSectionOutlineItemItemId}", ProjectBudgetIntroSectionOutlineItem.Id);
        return new DeactivateProjectBudgetIntroSectionOutlineItemResponse(ProjectBudgetIntroSectionOutlineItem.Id);
    }
}
