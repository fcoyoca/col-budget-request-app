using FluentValidation;
using budget_request_app.WebApi.ProjectRequestGroup.Persistence;

namespace budget_request_app.WebApi.ProjectRequestGroup.Features.Update.v1;
public class UpdateProjectRequestGroupValidator : AbstractValidator<UpdateProjectRequestGroupCommand>
{
    public UpdateProjectRequestGroupValidator(ProjectRequestGroupDbContext context)
    {
    }
}
