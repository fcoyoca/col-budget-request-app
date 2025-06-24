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
        var all = await repository.ListAsync(cancellationToken);

        int yearValue = DateTime.Now.Year;
        
        if (all.Any() && !request.IsUndo.GetValueOrDefault())
        {
            yearValue = all.Select(x => x.BudgetYear).Max();
            return await GetResponseFromInsert(yearValue + 1,cancellationToken);
        }

        if (!all.Any() && !request.IsUndo.GetValueOrDefault())
        {
            return await GetResponseFromInsert(yearValue, cancellationToken);
        }

        return new CreateBudgetYearResponse(null);
    }

    private async Task<CreateBudgetYearResponse> GetResponseFromInsert(int year, CancellationToken cancellationToken)
    {
        var item = BudgetYearItem.Create(year);
        await repository.AddAsync(item, cancellationToken).ConfigureAwait(false);
        await repository.SaveChangesAsync(cancellationToken).ConfigureAwait(false);
        logger.LogInformation("BudgetYear item created {BudgetYearItemId}", item.Id);
        return new CreateBudgetYearResponse(item.Id);
    }
}
