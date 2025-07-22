using FluentValidation;
using budget_request_app.WebApi.ProjectExpenditureCategory.Persistence;

namespace budget_request_app.WebApi.ProjectExpenditureCategory.Features.Create.v1;
public class CreateProjectExpenditureCategoryValidator : AbstractValidator<CreateProjectExpenditureCategoryCommand>
{
    public CreateProjectExpenditureCategoryValidator(ProjectExpenditureCategoryDbContext context)
    {
    }
}
