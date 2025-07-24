using FluentValidation;
using budget_request_app.WebApi.ProjectRequestStatus.Persistence;

namespace budget_request_app.WebApi.ProjectRequestStatus.Features.Create.v1;
public class CreateProjectRequestGroupValidator : AbstractValidator<CreateProjectRequestStatusCommand>
{
    public CreateProjectRequestGroupValidator(ProjectRequestStatusDbContext context)
    {
    }
}
