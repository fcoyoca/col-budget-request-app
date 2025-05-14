using System.Runtime.InteropServices.JavaScript;
using FSH.Framework.Core.Caching;
using FSH.Framework.Core.Persistence;
using budget_request_app.WebApi.BudgetYear.Domain;
using budget_request_app.WebApi.BudgetYear.Exceptions;
using budget_request_app.WebApi.LookupValue.Features.Get.v1;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace budget_request_app.WebApi.BudgetYear.Features.Get.v1;
public sealed class GetBudgetYearHandler(
    [FromKeyedServices("budgetYears")] IRepository<BudgetYearItem> repository,
    ICacheService cache)
    : IRequestHandler<GetBudgetYearRequest, GetBudgetYearResponse>
{
    public async Task<GetBudgetYearResponse> Handle(GetBudgetYearRequest request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        var listbudgetYears = await repository.ListAsync(cancellationToken);

        if (!listbudgetYears.Any())
        {
            var yearPayload = BudgetYearItem.Create(DateTime.Now.Year);
            var newBudgetYearItem = await repository.AddAsync(yearPayload, cancellationToken);
            return new GetBudgetYearResponse(newBudgetYearItem.Id, newBudgetYearItem.BudgetYear);
        }

        var maxYear = listbudgetYears.MaxBy(x => x.BudgetYear);

        return new GetBudgetYearResponse(maxYear.Id, maxYear.BudgetYear);
    }
}
