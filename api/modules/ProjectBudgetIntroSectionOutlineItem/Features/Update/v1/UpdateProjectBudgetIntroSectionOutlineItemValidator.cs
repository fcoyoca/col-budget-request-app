using FluentValidation;
using budget_request_app.WebApi.ProjectBudgetIntroSectionOutlineItem.Persistence;

namespace budget_request_app.WebApi.ProjectBudgetIntroSectionOutlineItem.Features.Update.v1;
public class UpdateProjectBudgetIntroSectionOutlineItemValidator : AbstractValidator<UpdateProjectBudgetIntroSectionOutlineItemCommand>
{
    public UpdateProjectBudgetIntroSectionOutlineItemValidator(ProjectBudgetIntroSectionOutlineItemDbContext context)
    {
    }
}
