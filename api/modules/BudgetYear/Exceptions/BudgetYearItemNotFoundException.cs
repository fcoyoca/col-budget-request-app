using FSH.Framework.Core.Exceptions;

namespace budget_request_app.WebApi.BudgetYear.Exceptions;
internal sealed class BudgetYearItemNotFoundException : NotFoundException
{
    public BudgetYearItemNotFoundException(Guid id)
        : base($"BudgetYear item with id {id} not found")
    {
    }
}
