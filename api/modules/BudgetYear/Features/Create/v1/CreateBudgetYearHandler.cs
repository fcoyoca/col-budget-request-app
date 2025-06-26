using FSH.Framework.Core.Persistence;
using budget_request_app.WebApi.BudgetYear.Domain;
using budget_request_app.WebApi.CapitalEquipment.Domain;
using budget_request_app.WebApi.CapitalProject.Domain;
using budget_request_app.WebApi.LookupCategory.Domain;
using budget_request_app.WebApi.LookupValue.Domain;
using Mapster;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using FundingYearItem = budget_request_app.WebApi.CapitalEquipment.Domain.FundingYearItem;

namespace budget_request_app.WebApi.BudgetYear.Features.Create.v1;
public sealed class CreateBudgetYearHandler(
    ILogger<CreateBudgetYearHandler> logger,
    [FromKeyedServices("budgetYears")] IRepository<BudgetYearItem> repository,
    [FromKeyedServices("lookupCategories")] IReadRepository<LookupCategoryItem> repositoryCategory,
    [FromKeyedServices("lookupValues")] IReadRepository<LookupValueItem> repositoryValue,
    [FromKeyedServices("capitalEquipmentsFundingItems")] IReadRepository<FundingItem> equipmentFundingRepository,
    [FromKeyedServices("capitalEquipmentsFundingYearItems")] IReadRepository<FundingYearItem> equipmentYearItemRepository,
    [FromKeyedServices("capitalEquipments")] IRepository<CapitalEquipmentItem> capitalEquipmentRepository,
    [FromKeyedServices("capitalProjects")] IRepository<CapitalProjectItem> capitalProjectRepository
    )
    : IRequestHandler<CreateBudgetYearCommand, CreateBudgetYearResponse>
{
    public async Task<CreateBudgetYearResponse> Handle(CreateBudgetYearCommand request, CancellationToken cancellationToken)
    {
        
        await CheckEquipmentRemainingFunding();

        await CheckProjectRemainingFunding();

        //await UpdateBudgetYear(all);
        
        return new CreateBudgetYearResponse(null);
    }

    private async Task<CreateBudgetYearResponse> UpdateBudgetYear()
    {
        var all = await repository.ListAsync();
        int yearValue = DateTime.Now.Year;
        
        if (all.Any())
        {
            yearValue = all.Select(x => x.BudgetYear).Max();
            return await GetResponseFromInsert(yearValue + 1);
        }
        else
        {
            return await GetResponseFromInsert(yearValue);
        }
    }
    

    private async Task<CreateBudgetYearResponse> GetResponseFromInsert(int year)
    {
        var item = BudgetYearItem.Create(year);
        
        await repository.AddAsync(item).ConfigureAwait(false);
        await repository.SaveChangesAsync().ConfigureAwait(false);
        logger.LogInformation("BudgetYear item created {BudgetYearItemId}", item.Id);
        return new CreateBudgetYearResponse(item.Id);
    }

    private async Task CheckEquipmentRemainingFunding()
    {
        List<Guid> hasFutureFundingGuids = new List<Guid>();
        List<Guid> hasNoFutureFundingGuids = new List<Guid>();
        
        var equipments = await capitalEquipmentRepository.ListAsync();
        var equipmentFundings = await equipmentFundingRepository.ListAsync();
        var equipmentYearItems = await equipmentYearItemRepository.ListAsync();
        var category = (await repositoryCategory.ListAsync()).FirstOrDefault(x => x.Name == "request_status");
        var values = (await repositoryValue.ListAsync()).Where(x => x.LookupCategoryId == category.Id);

        foreach (var equipment in equipments)
        {
            var fundings = equipment.FundingItems.Select(x => new FundingItemSummation()
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
    
    private async Task CheckProjectRemainingFunding()
    {
        List<Guid> hasFutureFundingGuids = new List<Guid>();
        List<Guid> hasNoFutureFundingGuids = new List<Guid>();

        var spec = new SearchCapitalProjectsSpec();
        var projects = await capitalProjectRepository.ListAsync(spec);
        var category = (await repositoryCategory.ListAsync()).FirstOrDefault(x => x.Name == "request_status_project");
        var values = (await repositoryValue.ListAsync()).Where(x => x.LookupCategoryId == category.Id);

        foreach (var project in projects)
        {

            var borrowingFundings = project.BorrowingFundings?.Select(x => new FundingItemSummation()
            {
                FutureYears = x.YearEstimates?
                    .Where(f => f.Year > Int32.Parse(project.BudgetId))
                    .Select(f => f.Value).Sum()
            });
            
            var operatingFundings = project.OperatingFundings?.Select(x => new FundingItemSummation()
            {
                FutureYears = x.YearEstimates?
                    .Where(f => f.Year > Int32.Parse(project.BudgetId))
                    .Select(f => f.Value).Sum()
            });
            
            var grantFundings = project.GrantFundings?.Select(x => new FundingItemSummation()
            {
                FutureYears = x.YearEstimates?
                    .Where(f => f.Year > Int32.Parse(project.BudgetId))
                    .Select(f => f.Value).Sum()
            });
            
            var donationFundings = project.DonationFundings?.Select(x => new FundingItemSummation()
            {
                FutureYears = x.YearEstimates?
                    .Where(f => f.Year > Int32.Parse(project.BudgetId))
                    .Select(f => f.Value).Sum()
            });
            
            var specialFundings = project.SpecialFundings?.Select(x => new FundingItemSummation()
            {
                FutureYears = x.YearEstimates?
                    .Where(f => f.Year > Int32.Parse(project.BudgetId))
                    .Select(f => f.Value).Sum()
            });
            
            var otherFundings = project.OtherFundings?.Select(x => new FundingItemSummation()
            {
                FutureYears = x.YearEstimates?
                    .Where(f => f.Year > Int32.Parse(project.BudgetId))
                    .Select(f => f.Value).Sum()
            });
            

            var fundings = new List<FundingItemSummation>()
                .Concat(borrowingFundings ?? new List<FundingItemSummation>())
                .Concat(operatingFundings ?? new List<FundingItemSummation>())
                .Concat(grantFundings ?? new List<FundingItemSummation>())
                .Concat(specialFundings ?? new List<FundingItemSummation>())
                .Concat(otherFundings ?? new List<FundingItemSummation>())
                .Concat(donationFundings ?? new List<FundingItemSummation>());
            
            
            var futureFundings = fundings.Sum(x => x.FutureYears);
            
            if (futureFundings > 0)
            {
                hasFutureFundingGuids.Add(project.Id);
            }
            else
            {
                hasNoFutureFundingGuids.Add(project.Id);
            }
        }
        
        var requiresDepartmentReviewStatus = values
             .FirstOrDefault(x => x.Name == "Requires Department Review")?.Id;
        
        var archivedStatus = values.FirstOrDefault(x => x.Name == "Archived")?.Id;
        
        var futureFundingProjects = projects.Where(x => hasFutureFundingGuids.Contains(x.Id));
        foreach (var project in futureFundingProjects)
        {
            project.GeneralInformation.RequestStatusId = requiresDepartmentReviewStatus.ToString();
        }
        
         var noFutureFundingProjects = projects.Where(x => hasNoFutureFundingGuids.Contains(x.Id));
         foreach (var project in noFutureFundingProjects)
         {
             project.GeneralInformation.RequestStatusId = archivedStatus.ToString();
         }
        
         var updatedProjects = futureFundingProjects.Concat(noFutureFundingProjects);
         
         await capitalProjectRepository.UpdateRangeAsync(updatedProjects);
    }

    private class FundingItemSummation
    {
        public Decimal? CurrentYear { get; set; }
        public Decimal? FutureYears { get; set; }
        public string? Type { get; set; }
    }

}
