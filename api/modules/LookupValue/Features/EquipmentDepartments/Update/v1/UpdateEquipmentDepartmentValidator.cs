using budget_request_app.WebApi.LookupValue.Persistence;
using FluentValidation;

namespace budget_request_app.WebApi.LookupValue.Features.EquipmentDepartments.Update.v1;
public class UpdateEquipmentDepartmentValidator : AbstractValidator<UpdateEquipmentDepartmentCommand>
{
    public UpdateEquipmentDepartmentValidator(LookupValueDbContext context)
    {
    }
}
