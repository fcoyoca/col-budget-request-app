using budget_request_app.WebApi.LookupValue.Persistence;
using FluentValidation;

namespace budget_request_app.WebApi.LookupValue.Features.EquipmentDepartments.Deactivate.v1;
public class DeactivateEquipmentDepartmentValidator : AbstractValidator<DeactivateEquipmentDepartmentCommand>
{
    public DeactivateEquipmentDepartmentValidator(LookupValueDbContext context)
    {
    }
}
