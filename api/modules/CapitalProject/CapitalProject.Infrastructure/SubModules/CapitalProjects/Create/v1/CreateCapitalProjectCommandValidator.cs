using budget_request_app.WebApi.CapitalProject.Domain;
using FluentValidation;
using FSH.Framework.Core.Persistence;
using Microsoft.Extensions.DependencyInjection;

namespace budget_request_app.WebApi.CapitalProject.Infrastructure.SubModules.CapitalProjects.Create.v1;
public class CreateCapitalProjectCommandValidator : AbstractValidator<CreateCapitalProjectCommand>
{
    public CreateCapitalProjectCommandValidator(
        [FromKeyedServices("capitalProjects")] IRepository<CapitalProjectItem> repository
        )
    {
        RuleFor(b => b.ProjectNumber)
            .MustAsync(async (value, cancellation) =>
            {
                var exists = (await repository.ListAsync())?.FirstOrDefault(x => x.ProjectNumber == value) != null;
                return !exists;
            })
            .WithMessage("Project number must be unique.");
        RuleFor(b => b.ProjectNumber).NotEmpty().Length(5);
    }
}
