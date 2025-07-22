using FSH.Framework.Core.Persistence;
using budget_request_app.WebApi.ProjectBudgetIntroSectionOutlineItem.Domain;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.ProjectBudgetIntroSectionOutlineItem.Features.Create.v1;
public sealed class CreateProjectBudgetIntroSectionOutlineItemHandler(
    ILogger<CreateProjectBudgetIntroSectionOutlineItemHandler> logger,
    [FromKeyedServices("ProjectBudgetIntroSectionOutlineItems")] IRepository<ProjectBudgetIntroSectionOutlineItemItem> repository)
    : IRequestHandler<CreateProjectBudgetIntroSectionOutlineItemCommand, CreateProjectBudgetIntroSectionOutlineItemResponse>
{
    public async Task<CreateProjectBudgetIntroSectionOutlineItemResponse> Handle(CreateProjectBudgetIntroSectionOutlineItemCommand request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        var item = ProjectBudgetIntroSectionOutlineItemItem.Create(
            request.BudgetId,
            request.SectionTitle,
            request.SortOrder,
            request.PageNumberOffset,
            request.LookupValueId
        );

        await repository.AddAsync(item, cancellationToken).ConfigureAwait(false);
        await repository.SaveChangesAsync(cancellationToken).ConfigureAwait(false);
        logger.LogInformation("ProjectBudgetIntroSectionOutlineItem item created {ProjectBudgetIntroSectionOutlineItemItemId}", item.Id);
        return new CreateProjectBudgetIntroSectionOutlineItemResponse(item.Id);
    }
}
