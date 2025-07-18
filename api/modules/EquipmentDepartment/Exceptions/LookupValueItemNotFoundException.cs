using FSH.Framework.Core.Exceptions;

namespace budget_request_app.WebApi.EquipmentDepartment.Exceptions;
internal sealed class EquipmentDepartmentItemNotFoundException : NotFoundException
{
    public EquipmentDepartmentItemNotFoundException(Guid id)
        : base($"EquipmentDepartment item with id {id} not found")
    {
    }
}
