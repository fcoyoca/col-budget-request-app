using FluentValidation;
using budget_request_app.WebApi.ProjectFundingSource.Persistence;

namespace budget_request_app.WebApi.ProjectFundingSource.Features.Create.v1;
public class CreateProjectFundingSourceValidator : AbstractValidator<CreateProjectFundingSourceCommand>
{
    public CreateProjectFundingSourceValidator(ProjectFundingSourceDbContext context)
    {
    }
}
