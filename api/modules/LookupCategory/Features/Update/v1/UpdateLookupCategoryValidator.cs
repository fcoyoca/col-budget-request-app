using FluentValidation;
using budget_request_app.WebApi.LookupCategory.Persistence;

namespace budget_request_app.WebApi.LookupCategory.Features.Update.v1;
public class UpdateLookupCategoryValidator : AbstractValidator<UpdateLookupCategoryCommand>
{
    public UpdateLookupCategoryValidator(LookupCategoryDbContext context)
    {
        RuleFor(p => p.Name).NotEmpty();
        RuleFor(p => p.Description).NotEmpty();
    }
}
