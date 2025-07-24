using FluentValidation;
using budget_request_app.WebApi.ProjectBudgetIntroSectionOutlineItem.Persistence;

namespace budget_request_app.WebApi.ProjectBudgetIntroSectionOutlineItem.Features.Create.v1;
public class CreateProjectRequestGroupValidator : AbstractValidator<CreateProjectBudgetIntroSectionOutlineItemCommand>
{
    public CreateProjectRequestGroupValidator(ProjectBudgetIntroSectionOutlineItemDbContext context)
    {
    }
}
