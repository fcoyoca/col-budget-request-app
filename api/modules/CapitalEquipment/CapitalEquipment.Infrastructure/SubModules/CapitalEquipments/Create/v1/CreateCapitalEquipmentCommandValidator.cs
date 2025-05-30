using budget_request_app.WebApi.CapitalEquipment.Domain;
using FluentValidation;
using FSH.Framework.Core.Persistence;
using Microsoft.Extensions.DependencyInjection;

namespace budget_request_app.WebApi.CapitalEquipment.Infrastructure.SubModules.CapitalEquipments.Create.v1;
public class CreateCapitalEquipmentCommandValidator : AbstractValidator<CreateCapitalEquipmentCommand>
{
    public CreateCapitalEquipmentCommandValidator(
        [FromKeyedServices("capitalEquipments")] IRepository<CapitalEquipmentItem> repository
        )
    {
        RuleFor(b => b.GeneralInfo.EquipmentName).NotEmpty();
        RuleFor(b => b.ProjectNumber)
            .MustAsync(async (value, cancellation) =>
            {
                var exists = (await repository.ListAsync())?.FirstOrDefault(x => x.ProjectNumber == value) != null;
                return !exists;
            })
            .WithMessage("Project number must be unique.");
    }
}
