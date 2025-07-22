using FluentValidation;
using budget_request_app.WebApi.ProjectRequestStatus.Persistence;

namespace budget_request_app.WebApi.ProjectRequestStatus.Features.Activate.v1;
public class ActivateProjectRequestStatusValidator : AbstractValidator<ActivateProjectRequestStatusCommand>
{
    public ActivateProjectRequestStatusValidator(ProjectRequestStatusDbContext context)
    {
    }
}
