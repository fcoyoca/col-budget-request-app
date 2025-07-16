using FluentValidation;
using budget_request_app.WebApi.EquipmentFundingSource.Persistence;

namespace budget_request_app.WebApi.EquipmentFundingSource.Features.Update.v1;
public class UpdateEquipmentFundingSourceValidator : AbstractValidator<UpdateEquipmentFundingSourceCommand>
{
    public UpdateEquipmentFundingSourceValidator(EquipmentFundingSourceDbContext context)
    {
    }
}
