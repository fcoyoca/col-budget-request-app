using FluentValidation;
using budget_request_app.WebApi.ProjectFundingSource.Persistence;

namespace budget_request_app.WebApi.ProjectFundingSource.Features.Activate.v1;
public class ActivateProjectFundingSourceValidator : AbstractValidator<ActivateProjectFundingSourceCommand>
{
    public ActivateProjectFundingSourceValidator(ProjectFundingSourceDbContext context)
    {
    }
}
