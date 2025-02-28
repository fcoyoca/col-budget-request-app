using FSH.Framework.Core.Exceptions;

namespace budget_request_app.WebApi.CapitalEquipment.Domain.Exceptions;
public sealed class GeneralInfoNotFoundException : NotFoundException
{
    public GeneralInfoNotFoundException(Guid id)
        : base($"GeneralInfo with id {id} not found")
    {
    }
}
