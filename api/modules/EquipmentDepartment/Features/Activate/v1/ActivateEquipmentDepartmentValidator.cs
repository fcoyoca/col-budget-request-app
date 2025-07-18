using FluentValidation;
using budget_request_app.WebApi.EquipmentDepartment.Persistence;

namespace budget_request_app.WebApi.EquipmentDepartment.Features.Activate.v1;
public class ActivateEquipmentDepartmentValidator : AbstractValidator<ActivateEquipmentDepartmentCommand>
{
    public ActivateEquipmentDepartmentValidator(EquipmentDepartmentDbContext context)
    {
    }
}
