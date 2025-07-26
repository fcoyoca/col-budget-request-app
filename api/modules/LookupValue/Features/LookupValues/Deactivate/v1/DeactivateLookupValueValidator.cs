using FluentValidation;
using budget_request_app.WebApi.LookupValue.Persistence;

namespace budget_request_app.WebApi.LookupValue.Features.LookupValues.Deactivate.v1;
public class DeactivateLookupValueValidator : AbstractValidator<DeactivateLookupValueCommand>
{
    public DeactivateLookupValueValidator(LookupValueDbContext context)
    {
    }
}
