using FluentValidation;
using budget_request_app.WebApi.ProjectFundingSource.Persistence;

namespace budget_request_app.WebApi.ProjectFundingSource.Features.Update.v1;
public class UpdateProjectFundingSourceValidator : AbstractValidator<UpdateProjectFundingSourceCommand>
{
    public UpdateProjectFundingSourceValidator(ProjectFundingSourceDbContext context)
    {
    }
}
