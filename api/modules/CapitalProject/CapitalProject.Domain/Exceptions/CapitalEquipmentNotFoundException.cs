using FSH.Framework.Core.Exceptions;

namespace budget_request_app.WebApi.CapitalEquipment.Domain.Exceptions;
public sealed class CapitalEquipmentNotFoundException : NotFoundException
{
    public CapitalEquipmentNotFoundException(Guid id)
        : base($"CapitalEquipment with id {id} not found")
    {
    }
}
