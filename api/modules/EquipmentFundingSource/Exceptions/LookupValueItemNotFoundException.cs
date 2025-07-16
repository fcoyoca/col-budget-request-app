using FSH.Framework.Core.Exceptions;

namespace budget_request_app.WebApi.EquipmentFundingSource.Exceptions;
internal sealed class EquipmentFundingSourceItemNotFoundException : NotFoundException
{
    public EquipmentFundingSourceItemNotFoundException(Guid id)
        : base($"EquipmentFundingSource item with id {id} not found")
    {
    }
}
