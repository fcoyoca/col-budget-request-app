using FSH.Framework.Core.Persistence;
using budget_request_app.WebApi.ProjectBudgetIntroSectionOutlineItem.Domain;
using budget_request_app.WebApi.ProjectBudgetIntroSectionOutlineItem.Exceptions;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.ProjectBudgetIntroSectionOutlineItem.Features.Update.v1;

public sealed class UpdateProjectBudgetIntroSectionOutlineItemHandler(
    ILogger<UpdateProjectBudgetIntroSectionOutlineItemHandler> logger,
    [FromKeyedServices("ProjectBudgetIntroSectionOutlineItems")] IRepository<ProjectBudgetIntroSectionOutlineItemItem> repository)
    : IRequestHandler<UpdateProjectBudgetIntroSectionOutlineItemCommand, UpdateProjectBudgetIntroSectionOutlineItemResponse>
{
    public async Task<UpdateProjectBudgetIntroSectionOutlineItemResponse> Handle(UpdateProjectBudgetIntroSectionOutlineItemCommand request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);

        var projectBudgetIntroSectionOutlineItem = await repository.GetByIdAsync(request.Id, cancellationToken);
        _ = projectBudgetIntroSectionOutlineItem ?? throw new ProjectBudgetIntroSectionOutlineItemItemNotFoundException(request.Id);

        // Update properties
        projectBudgetIntroSectionOutlineItem.BudgetId = request.BudgetId;
        projectBudgetIntroSectionOutlineItem.SectionTitle = request.SectionTitle;
        projectBudgetIntroSectionOutlineItem.SortOrder = request.SortOrder;
        projectBudgetIntroSectionOutlineItem.PageNumberOffset = request.PageNumberOffset;
        await repository.UpdateAsync(projectBudgetIntroSectionOutlineItem, cancellationToken);

        logger.LogInformation("ProjectBudgetIntroSectionOutlineItem item updated: {ProjectBudgetIntroSectionOutlineItemItemId}", projectBudgetIntroSectionOutlineItem.Id);

        return new UpdateProjectBudgetIntroSectionOutlineItemResponse(projectBudgetIntroSectionOutlineItem.Id);
    }
}
