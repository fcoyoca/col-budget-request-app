using budget_request_app.WebApi.LookupValue.Persistence;
using FluentValidation;

namespace budget_request_app.WebApi.LookupValue.Features.EquipmentDepartments.Create.v1;
public class CreateEquipmentDepartmentValidator : AbstractValidator<CreateEquipmentDepartmentCommand>
{
    public CreateEquipmentDepartmentValidator(LookupValueDbContext context)
    {
    }
}
