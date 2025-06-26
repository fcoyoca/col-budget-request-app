using FSH.Framework.Core.Persistence;
using budget_request_app.WebApi.BudgetYear.Domain;
using budget_request_app.WebApi.CapitalEquipment.Domain;
using budget_request_app.WebApi.LookupCategory.Domain;
using budget_request_app.WebApi.LookupValue.Domain;
using Mapster;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.BudgetYear.Features.Create.v1;
public sealed class CreateBudgetYearHandler(
    ILogger<CreateBudgetYearHandler> logger,
    [FromKeyedServices("budgetYears")] IRepository<BudgetYearItem> repository,
    [FromKeyedServices("lookupCategories")] IReadRepository<LookupCategoryItem> repositoryCategory,
    [FromKeyedServices("lookupValues")] IReadRepository<LookupValueItem> repositoryValue,
    [FromKeyedServices("capitalEquipmentsFundingItems")] IReadRepository<FundingItem> fundingRepository,
    [FromKeyedServices("capitalEquipmentsFundingYearItems")] IReadRepository<FundingYearItem> yearItemRepository,
    [FromKeyedServices("capitalEquipments")] IRepository<CapitalEquipmentItem> capitalEquipmentRepository
    )
    : IRequestHandler<CreateBudgetYearCommand, CreateBudgetYearResponse>
{
    public async Task<CreateBudgetYearResponse> Handle(CreateBudgetYearCommand request, CancellationToken cancellationToken)
    {
        //capitalEquipmentsFundingYearItems
        var all = await repository.ListAsync(cancellationToken);

        int yearValue = DateTime.Now.Year;
        
        await CheckEquipmentRemainingFunding();
        
        // if (all.Any() && !request.IsUndo.GetValueOrDefault())
        // {
        //     yearValue = all.Select(x => x.BudgetYear).Max();
        //     return await GetResponseFromInsert(yearValue + 1,cancellationToken);
        // }
        //
        // if (!all.Any() && !request.IsUndo.GetValueOrDefault())
        // {
        //     return await GetResponseFromInsert(yearValue, cancellationToken);
        // }

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

    private async Task CheckEquipmentRemainingFunding()
    {
        List<Guid> hasFutureFundingGuids = new List<Guid>();
        List<Guid> hasNoFutureFundingGuids = new List<Guid>();
        
        var equipments = await capitalEquipmentRepository.ListAsync();
        var equipmentFundings = await fundingRepository.ListAsync();
        var equipmentYearItems = await yearItemRepository.ListAsync();
        var category = (await repositoryCategory.ListAsync()).FirstOrDefault(x => x.Name == "request_status");
        var values = (await repositoryValue.ListAsync()).Where(x => x.LookupCategoryId == category.Id);

        foreach (var equipment in equipments)
        {
            var fundings = equipment.FundingItems.Select(x => new EquipmentFundingItem()
            {
                Type = x.FundingType,
                CurrentYear = x.CurrentYearRequested.Value,
                FutureYears = x.YearEstimates
                    .Where(f => f.Year > x.CurrentYearRequested.Year)
                    .Select(f => f.Value.GetValueOrDefault()).Sum()
            });

            var futureFundings = fundings.Sum(x => x.FutureYears);

            if (futureFundings > 0)
            {
                hasFutureFundingGuids.Add(equipment.Id);
            }
            else
            {
                hasNoFutureFundingGuids.Add(equipment.Id);
            }

        }

        var requiresDepartmentReviewStatus = values
            .FirstOrDefault(x => x.Name == "Requires Department Review")?.Id;
        
        var archivedStatus = values.FirstOrDefault(x => x.Name == "Archived")?.Id;
        
        var futureFundingEquipments = equipments.Where(x => hasFutureFundingGuids.Contains(x.Id));
        foreach (var equipment in futureFundingEquipments)
        {
            equipment.RequestStatusId = requiresDepartmentReviewStatus.ToString();
        }
        
        var noFutureFundingEquipments = equipments.Where(x => hasNoFutureFundingGuids.Contains(x.Id));
        foreach (var equipment in noFutureFundingEquipments)
        {
            equipment.RequestStatusId = archivedStatus.ToString();
        }

        var updatedEquipments = futureFundingEquipments.Concat(noFutureFundingEquipments);
        
        await capitalEquipmentRepository.UpdateRangeAsync(updatedEquipments);

    }

    private class EquipmentFundingItem
    {
        public Decimal? CurrentYear { get; set; }
        public Decimal? FutureYears { get; set; }
        public string? Type { get; set; }
    }

}
