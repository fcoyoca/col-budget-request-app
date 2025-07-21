using FluentValidation;
using budget_request_app.WebApi.ProjectRequestSubGroup.Persistence;

namespace budget_request_app.WebApi.ProjectRequestSubGroup.Features.Create.v1;
public class CreateProjectRequestSubGroupValidator : AbstractValidator<CreateProjectRequestSubGroupCommand>
{
    public CreateProjectRequestSubGroupValidator(ProjectRequestSubGroupDbContext context)
    {
    }
}
