using budget_request_app.WebApi.LookupValue.Persistence;
using FluentValidation;

namespace budget_request_app.WebApi.LookupValue.Features.EquipmentDepartments.Activate.v1;
public class ActivateEquipmentDepartmentValidator : AbstractValidator<ActivateEquipmentDepartmentCommand>
{
    public ActivateEquipmentDepartmentValidator(LookupValueDbContext context)
    {
    }
}
