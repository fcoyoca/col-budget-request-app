using FluentValidation;
using budget_request_app.WebApi.ProjectRequestGroup.Persistence;

namespace budget_request_app.WebApi.ProjectRequestGroup.Features.Create.v1;
public class CreateProjectRequestGroupValidator : AbstractValidator<CreateProjectRequestGroupCommand>
{
    public CreateProjectRequestGroupValidator(ProjectRequestGroupDbContext context)
    {
    }
}
