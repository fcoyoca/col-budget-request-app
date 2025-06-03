using budget_request_app.WebApi.CapitalEquipment.Domain;
using FluentValidation;
using FSH.Framework.Core.Persistence;
using Microsoft.Extensions.DependencyInjection;

namespace budget_request_app.WebApi.CapitalEquipment.Infrastructure.SubModules.CapitalEquipments.Update.v1;
public class UpdateStatusCapitalEquipmentCommandValidator : AbstractValidator<UpdateStatusCapitalEquipmentCommand>
{
    public UpdateStatusCapitalEquipmentCommandValidator(
        )
    {
    }
}
