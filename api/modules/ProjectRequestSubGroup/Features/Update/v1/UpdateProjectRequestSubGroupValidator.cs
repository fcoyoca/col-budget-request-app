using FluentValidation;
using budget_request_app.WebApi.ProjectRequestSubGroup.Persistence;

namespace budget_request_app.WebApi.ProjectRequestSubGroup.Features.Update.v1;
public class UpdateProjectRequestSubGroupValidator : AbstractValidator<UpdateProjectRequestSubGroupCommand>
{
    public UpdateProjectRequestSubGroupValidator(ProjectRequestSubGroupDbContext context)
    {
    }
}
