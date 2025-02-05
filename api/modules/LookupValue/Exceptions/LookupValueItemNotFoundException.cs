using FSH.Framework.Core.Exceptions;

namespace budget_request_app.WebApi.LookupValue.Exceptions;
internal sealed class LookupValueItemNotFoundException : NotFoundException
{
    public LookupValueItemNotFoundException(Guid id)
        : base($"LookupValue item with id {id} not found")
    {
    }
}
