using FluentValidation;
using budget_request_app.WebApi.ProjectRequestStatus.Persistence;

namespace budget_request_app.WebApi.ProjectRequestStatus.Features.Deactivate.v1;
public class DeactivateProjectRequestStatusValidator : AbstractValidator<DeactivateProjectRequestStatusCommand>
{
    public DeactivateProjectRequestStatusValidator(ProjectRequestStatusDbContext context)
    {
    }
}
