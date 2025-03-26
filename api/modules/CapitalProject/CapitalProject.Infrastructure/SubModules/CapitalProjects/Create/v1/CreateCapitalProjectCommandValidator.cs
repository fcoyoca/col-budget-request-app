using FluentValidation;

namespace budget_request_app.WebApi.CapitalProject.Infrastructure.SubModules.CapitalProjects.Create.v1;
public class CreateCapitalProjectCommandValidator : AbstractValidator<CreateCapitalProjectCommand>
{
    public CreateCapitalProjectCommandValidator()
    {
    }
}
