using FSH.Framework.Core.Exceptions;

namespace budget_request_app.WebApi.ProjectBudgetIntroSectionOutlineItem.Exceptions;
internal sealed class ProjectBudgetIntroSectionOutlineItemItemNotFoundException : NotFoundException
{
    public ProjectBudgetIntroSectionOutlineItemItemNotFoundException(Guid id)
        : base($"ProjectBudgetIntroSectionOutlineItem item with id {id} not found")
    {
    }
}
