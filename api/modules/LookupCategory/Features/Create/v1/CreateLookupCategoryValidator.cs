using FluentValidation;
using budget_request_app.WebApi.LookupCategory.Persistence;

namespace budget_request_app.WebApi.LookupCategory.Features.Create.v1;
public class CreateLookupCategoryValidator : AbstractValidator<CreateLookupCategoryCommand>
{
    public CreateLookupCategoryValidator(LookupCategoryDbContext context)
    {
        RuleFor(p => p.Name).NotEmpty();
        RuleFor(p => p.Description).NotEmpty();
    }
}
