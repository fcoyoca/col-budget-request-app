using FluentValidation;

namespace budget_request_app.WebApi.CapitalEquipment.Infrastructure.SubModules.CapitalEquipments.Create.v1;
public class CreateCapitalEquipmentCommandValidator : AbstractValidator<CreateCapitalEquipmentCommand>
{
    public CreateCapitalEquipmentCommandValidator()
    {
        RuleFor(b => b.GeneralInfo.EquipmentName).NotEmpty();
        // RuleFor(b => b.Funding.BorrowingFundings)
        //     .Must(x => x.Any())
        //     .WithMessage("walay sulod ang borrowing fundings");
    }
}
