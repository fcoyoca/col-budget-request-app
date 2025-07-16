using FluentValidation;
using budget_request_app.WebApi.EquipmentFundingSource.Persistence;

namespace budget_request_app.WebApi.EquipmentFundingSource.Features.Activate.v1;
public class ActivateEquipmentFundingSourceValidator : AbstractValidator<ActivateEquipmentFundingSourceCommand>
{
    public ActivateEquipmentFundingSourceValidator(EquipmentFundingSourceDbContext context)
    {
    }
}
