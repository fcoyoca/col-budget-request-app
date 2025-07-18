using FluentValidation;
using budget_request_app.WebApi.EquipmentDepartment.Persistence;

namespace budget_request_app.WebApi.EquipmentDepartment.Features.Deactivate.v1;
public class DeactivateEquipmentDepartmentValidator : AbstractValidator<DeactivateEquipmentDepartmentCommand>
{
    public DeactivateEquipmentDepartmentValidator(EquipmentDepartmentDbContext context)
    {
    }
}
