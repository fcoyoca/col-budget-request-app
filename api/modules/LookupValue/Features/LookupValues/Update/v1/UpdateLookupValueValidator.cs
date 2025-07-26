using FluentValidation;
using budget_request_app.WebApi.LookupValue.Persistence;

namespace budget_request_app.WebApi.LookupValue.Features.LookupValues.Update.v1;
public class UpdateLookupValueValidator : AbstractValidator<UpdateLookupValueCommand>
{
    public UpdateLookupValueValidator(LookupValueDbContext context)
    {
        RuleFor(p => p.Name).NotEmpty();
        RuleFor(p => p.LookupCategoryId).NotEmpty();
    }
}
