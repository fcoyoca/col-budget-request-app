using FluentValidation;
using budget_request_app.WebApi.ProjectRequestSubGroup.Persistence;

namespace budget_request_app.WebApi.ProjectRequestSubGroup.Features.Activate.v1;
public class ActivateProjectRequestSubGroupValidator : AbstractValidator<ActivateProjectRequestSubGroupCommand>
{
    public ActivateProjectRequestSubGroupValidator(ProjectRequestSubGroupDbContext context)
    {
    }
}
