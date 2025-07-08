using FluentValidation;
using budget_request_app.WebApi.EquipmentFundingSource.Persistence;

namespace budget_request_app.WebApi.EquipmentFundingSource.Features.Create.v1;
public class CreateEquipmentFundingSourceValidator : AbstractValidator<CreateEquipmentFundingSourceCommand>
{
    public CreateEquipmentFundingSourceValidator(EquipmentFundingSourceDbContext context)
    {
    }
}
