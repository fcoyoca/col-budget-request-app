using FluentValidation;
using budget_request_app.WebApi.ProjectBudgetIntroSectionOutlineItem.Persistence;

namespace budget_request_app.WebApi.ProjectBudgetIntroSectionOutlineItem.Features.Activate.v1;
public class ActivateProjectBudgetIntroSectionOutlineItemValidator : AbstractValidator<ActivateProjectBudgetIntroSectionOutlineItemCommand>
{
    public ActivateProjectBudgetIntroSectionOutlineItemValidator(ProjectBudgetIntroSectionOutlineItemDbContext context)
    {
    }
}
