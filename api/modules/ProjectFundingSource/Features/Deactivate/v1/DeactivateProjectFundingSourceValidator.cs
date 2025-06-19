using FluentValidation;
using budget_request_app.WebApi.ProjectFundingSource.Persistence;

namespace budget_request_app.WebApi.ProjectFundingSource.Features.Deactivate.v1;
public class DeactivateProjectFundingSourceValidator : AbstractValidator<DeactivateProjectFundingSourceCommand>
{
    public DeactivateProjectFundingSourceValidator(ProjectFundingSourceDbContext context)
    {
    }
}
