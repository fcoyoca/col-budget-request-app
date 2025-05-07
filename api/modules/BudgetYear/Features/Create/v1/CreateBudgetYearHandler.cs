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
        var currentYear = DateTime.Now.Year;

        if (all.Any() && !request.IsUndo.GetValueOrDefault())
        {
            var maxYear = all.Select(x => x.BudgetYear).Max();
            if (maxYear < currentYear)
            {
                return await GetResponse(cancellationToken);
            }
        }

        if (!all.Any() && !request.IsUndo.GetValueOrDefault())
        {

            return await GetResponse(cancellationToken);
        }

        if (request.IsUndo.GetValueOrDefault())
        {
            var currentYearInserted = all.FirstOrDefault(x => x.BudgetYear == currentYear);
            
            await repository.DeleteAsync(currentYearInserted, cancellationToken);
        }

        return new CreateBudgetYearResponse(null);
    }

    private async Task<CreateBudgetYearResponse> GetResponse(CancellationToken cancellationToken)
    {
        var currentYear = DateTime.Now.Year;
        var item = BudgetYearItem.Create(currentYear);
        await repository.AddAsync(item, cancellationToken).ConfigureAwait(false);
        await repository.SaveChangesAsync(cancellationToken).ConfigureAwait(false);
        logger.LogInformation("BudgetYear item created {BudgetYearItemId}", item.Id);
        return new CreateBudgetYearResponse(item.Id);
    }
}
