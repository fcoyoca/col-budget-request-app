using FluentValidation;
using budget_request_app.WebApi.ProjectExpenditureCategory.Persistence;

namespace budget_request_app.WebApi.ProjectExpenditureCategory.Features.Update.v1;
public class UpdateProjectExpenditureCategoryValidator : AbstractValidator<UpdateProjectExpenditureCategoryCommand>
{
    public UpdateProjectExpenditureCategoryValidator(ProjectExpenditureCategoryDbContext context)
    {
    }
}
