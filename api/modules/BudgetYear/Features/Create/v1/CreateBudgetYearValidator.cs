using FluentValidation;
using budget_request_app.WebApi.BudgetYear.Persistence;

namespace budget_request_app.WebApi.BudgetYear.Features.Create.v1;
public class CreateBudgetYearValidator : AbstractValidator<CreateBudgetYearCommand>
{
    public CreateBudgetYearValidator(BudgetYearDbContext context)
    {
    }
}
