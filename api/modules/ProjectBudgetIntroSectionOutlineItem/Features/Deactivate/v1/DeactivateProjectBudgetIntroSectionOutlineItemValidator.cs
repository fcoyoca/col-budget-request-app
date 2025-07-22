using FluentValidation;
using budget_request_app.WebApi.ProjectBudgetIntroSectionOutlineItem.Persistence;

namespace budget_request_app.WebApi.ProjectBudgetIntroSectionOutlineItem.Features.Deactivate.v1;
public class DeactivateProjectBudgetIntroSectionOutlineItemValidator : AbstractValidator<DeactivateProjectBudgetIntroSectionOutlineItemCommand>
{
    public DeactivateProjectBudgetIntroSectionOutlineItemValidator(ProjectBudgetIntroSectionOutlineItemDbContext context)
    {
    }
}
