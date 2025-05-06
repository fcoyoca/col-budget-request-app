using FSH.Framework.Core.Persistence;
using budget_request_app.WebApi.BudgetYear.Domain;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.BudgetYear.Features.Create.v1;
public sealed class CreateBudgetYearHandler(
    ILogger<CreateBudgetYearHandler> logger,
    [FromKeyedServices("budgetYears")] IRepository<BudgetYearItem> repository)
    : IRequestHandler<CreateBudgetYearCommand, CreateBudgetYearResponse>
{
    public async Task<CreateBudgetYearResponse> Handle(CreateBudgetYearCommand request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);

        var all = await repository.ListAsync(cancellationToken);

        var maxYear = all.Select(x => x.BudgetYear).Max();
        var currentYear = DateTime.Now.Year;

        if (maxYear >= currentYear)
        {
            ArgumentNullException.ThrowIfNull(request);
        }

        var item = BudgetYearItem.Create(currentYear);
        await repository.AddAsync(item, cancellationToken).ConfigureAwait(false);
        await repository.SaveChangesAsync(cancellationToken).ConfigureAwait(false);
        logger.LogInformation("BudgetYear item created {BudgetYearItemId}", item.Id);
        return new CreateBudgetYearResponse(item.Id);
    }
}
