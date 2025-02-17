using FluentValidation;
using budget_request_app.WebApi.LookupValue.Persistence;

namespace budget_request_app.WebApi.LookupValue.Features.Activate.v1;
public class ActivateLookupValueValidator : AbstractValidator<ActivateLookupValueCommand>
{
    public ActivateLookupValueValidator(LookupValueDbContext context)
    {
    }
}
