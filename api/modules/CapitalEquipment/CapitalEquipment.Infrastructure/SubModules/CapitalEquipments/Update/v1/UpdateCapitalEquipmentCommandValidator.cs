using budget_request_app.WebApi.CapitalEquipment.Domain;
using FluentValidation;
using FSH.Framework.Core.Persistence;
using Microsoft.Extensions.DependencyInjection;

namespace budget_request_app.WebApi.CapitalEquipment.Infrastructure.SubModules.CapitalEquipments.Update.v1;
public class UpdateCapitalEquipmentCommandValidator : AbstractValidator<UpdateCapitalEquipmentCommand>
{
    public UpdateCapitalEquipmentCommandValidator(
        [FromKeyedServices("capitalEquipments")] IRepository<CapitalEquipmentItem> repository
        )
    {
        RuleFor(b => b.GeneralInfo.EquipmentName).NotEmpty();
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
