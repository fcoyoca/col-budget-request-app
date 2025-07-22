using budget_request_app.WebApi.ProjectBudgetIntroSectionOutlineItem.Domain;
using budget_request_app.WebApi.ProjectBudgetIntroSectionOutlineItem.Exceptions;
using FSH.Framework.Core.Persistence;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.ProjectBudgetIntroSectionOutlineItem.Features.Activate.v1;
public sealed class ActivateProjectBudgetIntroSectionOutlineItemHandler(
    ILogger<ActivateProjectBudgetIntroSectionOutlineItemHandler> logger,
    [FromKeyedServices("ProjectBudgetIntroSectionOutlineItems")] IRepository<ProjectBudgetIntroSectionOutlineItemItem> repository)
    : IRequestHandler<ActivateProjectBudgetIntroSectionOutlineItemCommand, ActivateProjectBudgetIntroSectionOutlineItemResponse>
{
    public async Task<ActivateProjectBudgetIntroSectionOutlineItemResponse> Handle(ActivateProjectBudgetIntroSectionOutlineItemCommand request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        var ProjectBudgetIntroSectionOutlineItem = await repository.GetByIdAsync(request.Id, cancellationToken);
        _ = ProjectBudgetIntroSectionOutlineItem ?? throw new ProjectBudgetIntroSectionOutlineItemItemNotFoundException(request.Id.Value);
        ProjectBudgetIntroSectionOutlineItem.IsActive = true;
        await repository.UpdateAsync(ProjectBudgetIntroSectionOutlineItem, cancellationToken);
        logger.LogInformation("ProjectBudgetIntroSectionOutlineItem item Activated {ProjectBudgetIntroSectionOutlineItemItemId}", ProjectBudgetIntroSectionOutlineItem.Id);
        return new ActivateProjectBudgetIntroSectionOutlineItemResponse(ProjectBudgetIntroSectionOutlineItem.Id);
    }
}
