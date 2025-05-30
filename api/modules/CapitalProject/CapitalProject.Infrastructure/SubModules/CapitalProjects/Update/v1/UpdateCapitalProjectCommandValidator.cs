using budget_request_app.WebApi.CapitalProject.Domain;
using FluentValidation;
using FSH.Framework.Core.Persistence;
using Microsoft.Extensions.DependencyInjection;

namespace budget_request_app.WebApi.CapitalProject.Infrastructure.SubModules.CapitalProjects.Update.v1;
public class UpdateCapitalProjectCommandValidator : AbstractValidator<UpdateCapitalProjectCommand>
{
    public UpdateCapitalProjectCommandValidator(
        [FromKeyedServices("capitalProjects")] IRepository<CapitalProjectItem> repository
    )
    {
        RuleFor(b => b.ProjectNumber)
            .MustAsync(async (command, value, cancellation) =>
            {
                var allData = (await repository.ListAsync());
                
                var target = allData.FirstOrDefault(x => x.ProjectNumber == command.ProjectNumber);

                return !(target is not null && target.Id != command.Id) ;
            })
            .WithMessage("Project number must be unique.");
    }
}
