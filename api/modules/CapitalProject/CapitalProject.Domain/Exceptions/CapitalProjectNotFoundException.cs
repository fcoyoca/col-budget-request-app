using FSH.Framework.Core.Exceptions;

namespace budget_request_app.WebApi.CapitalProject.Domain.Exceptions;
public sealed class CapitalProjectNotFoundException : NotFoundException
{
    public CapitalProjectNotFoundException(Guid id)
        : base($"CapitalProject with id {id} not found")
    {
    }
}
