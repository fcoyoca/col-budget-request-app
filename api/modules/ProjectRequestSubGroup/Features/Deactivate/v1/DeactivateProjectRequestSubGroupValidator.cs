using FluentValidation;
using budget_request_app.WebApi.ProjectRequestSubGroup.Persistence;

namespace budget_request_app.WebApi.ProjectRequestSubGroup.Features.Deactivate.v1;
public class DeactivateProjectRequestSubGroupValidator : AbstractValidator<DeactivateProjectRequestSubGroupCommand>
{
    public DeactivateProjectRequestSubGroupValidator(ProjectRequestSubGroupDbContext context)
    {
    }
}
