using FSH.Framework.Core.Domain;
using FSH.Framework.Core.Domain.Contracts;
using budget_request_app.WebApi.BudgetYear.Domain.Events;

namespace budget_request_app.WebApi.BudgetYear.Domain;
public class BudgetYearItem : AuditableEntity, IAggregateRoot
{
    public int BudgetYear { get; set; }
    public static BudgetYearItem Create(int budgetYear)
    {
        var item = new BudgetYearItem();

        item.BudgetYear = budgetYear;

        item.QueueDomainEvent(new BudgetYearItemCreated(item.Id, item.BudgetYear));

        return item;
    }

    public BudgetYearItem Update(int budgetYear)
    {
        this.QueueDomainEvent(new BudgetYearItemUpdated(this));

        return this;
    }
}
