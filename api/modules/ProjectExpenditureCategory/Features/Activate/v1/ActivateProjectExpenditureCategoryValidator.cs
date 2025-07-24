using FluentValidation;
using budget_request_app.WebApi.ProjectExpenditureCategory.Persistence;

namespace budget_request_app.WebApi.ProjectExpenditureCategory.Features.Activate.v1;
public class ActivateProjectExpenditureCategoryValidator : AbstractValidator<ActivateProjectExpenditureCategoryCommand>
{
    public ActivateProjectExpenditureCategoryValidator(ProjectExpenditureCategoryDbContext context)
    {
    }
}
