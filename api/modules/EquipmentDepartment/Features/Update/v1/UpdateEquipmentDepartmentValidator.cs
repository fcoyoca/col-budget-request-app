using FluentValidation;
using budget_request_app.WebApi.EquipmentDepartment.Persistence;

namespace budget_request_app.WebApi.EquipmentDepartment.Features.Update.v1;
public class UpdateEquipmentDepartmentValidator : AbstractValidator<UpdateEquipmentDepartmentCommand>
{
    public UpdateEquipmentDepartmentValidator(EquipmentDepartmentDbContext context)
    {
    }
}
