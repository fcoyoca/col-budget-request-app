using FluentValidation;
using budget_request_app.WebApi.EquipmentDepartment.Persistence;

namespace budget_request_app.WebApi.EquipmentDepartment.Features.Create.v1;
public class CreateEquipmentDepartmentValidator : AbstractValidator<CreateEquipmentDepartmentCommand>
{
    public CreateEquipmentDepartmentValidator(EquipmentDepartmentDbContext context)
    {
    }
}
