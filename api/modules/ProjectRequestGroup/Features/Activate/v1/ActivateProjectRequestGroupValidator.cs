using FluentValidation;
using budget_request_app.WebApi.ProjectRequestGroup.Persistence;

namespace budget_request_app.WebApi.ProjectRequestGroup.Features.Activate.v1;
public class ActivateProjectRequestGroupValidator : AbstractValidator<ActivateProjectRequestGroupCommand>
{
    public ActivateProjectRequestGroupValidator(ProjectRequestGroupDbContext context)
    {
    }
}
