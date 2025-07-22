using FluentValidation;
using budget_request_app.WebApi.ProjectRequestStatus.Persistence;

namespace budget_request_app.WebApi.ProjectRequestStatus.Features.Update.v1;
public class UpdateProjectRequestStatusValidator : AbstractValidator<UpdateProjectRequestStatusCommand>
{
    public UpdateProjectRequestStatusValidator(ProjectRequestStatusDbContext context)
    {
    }
}
