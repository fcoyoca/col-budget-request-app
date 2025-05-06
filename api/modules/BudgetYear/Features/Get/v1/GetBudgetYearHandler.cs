using FSH.Framework.Core.Caching;
using FSH.Framework.Core.Persistence;
using budget_request_app.WebApi.BudgetYear.Domain;
using budget_request_app.WebApi.BudgetYear.Exceptions;
using budget_request_app.WebApi.LookupValue.Features.Get.v1;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace budget_request_app.WebApi.BudgetYear.Features.Get.v1;
public sealed class GetBudgetYearHandler(
    [FromKeyedServices("budgetYears")] IReadRepository<BudgetYearItem> repository,
    ICacheService cache)
    : IRequestHandler<GetBudgetYearRequest, GetBudgetYearResponse>
{
    public async Task<GetBudgetYearResponse> Handle(GetBudgetYearRequest request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        var item = await cache.GetOrSetAsync(
            $"BudgetYear:{request.Id}",
            async () =>
            {
                var BudgetYearItem = await repository.GetByIdAsync(request.Id, cancellationToken);
                if (BudgetYearItem == null) throw new BudgetYearItemNotFoundException(request.Id);
                return new GetBudgetYearResponse(BudgetYearItem.Id, BudgetYearItem.BudgetYear);
            },
            cancellationToken: cancellationToken);
        return item!;
    }
}
