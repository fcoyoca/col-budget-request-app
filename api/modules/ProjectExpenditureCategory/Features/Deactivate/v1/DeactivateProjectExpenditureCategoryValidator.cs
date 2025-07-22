using FluentValidation;
using budget_request_app.WebApi.ProjectExpenditureCategory.Persistence;

namespace budget_request_app.WebApi.ProjectExpenditureCategory.Features.Deactivate.v1;
public class DeactivateProjectExpenditureCategoryValidator : AbstractValidator<DeactivateProjectExpenditureCategoryCommand>
{
    public DeactivateProjectExpenditureCategoryValidator(ProjectExpenditureCategoryDbContext context)
    {
    }
}
