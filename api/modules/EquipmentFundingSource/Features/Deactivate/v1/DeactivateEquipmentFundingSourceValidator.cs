using FluentValidation;
using budget_request_app.WebApi.EquipmentFundingSource.Persistence;

namespace budget_request_app.WebApi.EquipmentFundingSource.Features.Deactivate.v1;
public class DeactivateEquipmentFundingSourceValidator : AbstractValidator<DeactivateEquipmentFundingSourceCommand>
{
    public DeactivateEquipmentFundingSourceValidator(EquipmentFundingSourceDbContext context)
    {
    }
}
