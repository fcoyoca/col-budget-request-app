using FluentValidation;
using budget_request_app.WebApi.ProjectRequestGroup.Persistence;

namespace budget_request_app.WebApi.ProjectRequestGroup.Features.Deactivate.v1;
public class DeactivateProjectRequestGroupValidator : AbstractValidator<DeactivateProjectRequestGroupCommand>
{
    public DeactivateProjectRequestGroupValidator(ProjectRequestGroupDbContext context)
    {
    }
}
