using System;
using System.Linq;
using System.Threading;
using budget_request_app.WebApi.BudgetYear.Domain;
using budget_request_app.WebApi.CapitalEquipment.Domain;
using budget_request_app.WebApi.CapitalProject.Domain;
using budget_request_app.WebApi.LookupCategory.Domain;
using budget_request_app.WebApi.LookupValue.Domain;
using FSH.Framework.Core.Domain;
using FSH.Framework.Core.Domain.Contracts;
using FSH.Framework.Core.Persistence;
using FSH.Framework.Core.Storage;
using Mapster;
using MediatR;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MimeKit.IO;
using FundingYearItem = budget_request_app.WebApi.CapitalEquipment.Domain.FundingYearItem;
using FundingYearItemProject = budget_request_app.WebApi.CapitalProject.Domain.FundingYearItem;

namespace budget_request_app.WebApi.BudgetYear.Features.Create.v1;
public sealed class CreateBudgetYearHandler(
    ILogger<CreateBudgetYearHandler> logger,
    IConfiguration configuration,
    [FromKeyedServices("budgetYears")] IRepository<BudgetYearItem> repository,
    [FromKeyedServices("lookupCategories")] IReadRepository<LookupCategoryItem> repositoryCategory,
    [FromKeyedServices("lookupValues")] IReadRepository<LookupValueItem> repositoryValue,
    [FromKeyedServices("capitalEquipmentsFundingItems")] IRepository<FundingItem> equipmentFundingRepository,
    [FromKeyedServices("capitalEquipmentsFundingYearItems")] IReadRepository<FundingYearItem> equipmentYearItemRepository,
    [FromKeyedServices("capitalEquipments")] IRepository<CapitalEquipmentItem> capitalEquipmentRepository,
    [FromKeyedServices("capitalProjects")] IRepository<CapitalProjectItem> capitalProjectRepository
    )
    : IRequestHandler<CreateBudgetYearCommand, CreateBudgetYearResponse>
{
    public async Task<CreateBudgetYearResponse> Handle(CreateBudgetYearCommand request, CancellationToken cancellationToken)
    {
        try
        {
            await BackupDB();

            await CheckEquipmentRemainingFunding();

            await CheckProjectRemainingFunding();

            await ForwardEquipmentFundingYears();

            await ForwardProjectFundingYears();

            var result = await UpdateBudgetYear();

            return new CreateBudgetYearResponse(result.Id, result.Message);

        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Cutover Error: {Message}", ex.Message);
            return new CreateBudgetYearResponse(null, "BudgetYear Error :" + ex.Message);
        }
    }

    private async Task BackupDB()
    {
        var backUpPath = $"{configuration.GetValue<string>("FileStorage:BackUpPath")}";
        var rootDrive = Path.GetPathRoot(AppContext.BaseDirectory); // e.g., "D:\", "C:\"
        var combinedPath = Path.Combine(rootDrive, backUpPath);

        // Ensure directory exists
        if (!Directory.Exists(combinedPath))
        {
            Directory.CreateDirectory(combinedPath);
        }

        string connectionString = $"{configuration.GetValue<string>("DatabaseOptions:ConnectionString")}";
        var backUpPathFileName = @combinedPath + "/BudgetingNewDb_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".bak";

        var backupSql = $@"
            BACKUP DATABASE [BudgetingNewDb] 
            TO DISK = N'{backUpPathFileName}' 
            WITH FORMAT, INIT, SKIP, NOREWIND, NOUNLOAD, STATS = 10";

        try
        {
            using var connection = new SqlConnection(connectionString);
            using var command = new SqlCommand(backupSql, connection);

            await connection.OpenAsync();
            await command.ExecuteNonQueryAsync();


            logger.LogInformation($"Backup completed to: {backUpPathFileName}");
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Backup failed: {Message}", ex.Message);
        }
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

    private async Task ForwardEquipmentFundingYears()
    {
        try
        {
            var equipments = await capitalEquipmentRepository.ListAsync();
            var allYears = await repository.ListAsync();
            int yearValue = DateTime.Now.Year;
            yearValue = allYears.Select(x => x.BudgetYear).Max();

            var category = (await repositoryCategory.ListAsync()).FirstOrDefault(x => x.Name == "request_status");
            var values = (await repositoryValue.ListAsync()).Where(x => x.LookupCategoryId == category.Id);
            var archivedStatus = values.FirstOrDefault(x => x.Name == "Archived")?.Id;
            var filteredEquipments = equipments.Where(x => x.RequestStatusId != archivedStatus.ToString());

            foreach (var equipment in filteredEquipments)
            {
                equipment.BudgetId = (yearValue + 1).ToString();

                foreach (var funding in equipment.FundingItems ?? Enumerable.Empty<FundingItem>())
                {
                    var sortedEstimates = funding.YearEstimates?
                        .Where(y => y.Year != null)
                        .OrderBy(y => y.Year)
                        .ToList() ?? new List<FundingYearItem>();

                    var sortedCurrentRequested = funding.YearEstimates?.Where(y => y.Year != null).OrderBy(y => y.Year).ToList() ?? new List<FundingYearItem>();

                    var firstEstimate = sortedCurrentRequested.FirstOrDefault();
                    if (firstEstimate != null)
                    {
                        funding.CurrentYearRequested.Year = firstEstimate.Year;
                        funding.CurrentYearRequested.Value = firstEstimate.Value;
                    }

                    while (sortedEstimates.Count < 5)
                    {
                        var newYear = (sortedEstimates.LastOrDefault()?.Year ?? DateTime.Now.Year) + 1;
                        var newItem = new FundingYearItem
                        {
                            Year = newYear,
                            Value = 0.00m
                        };
                        funding.YearEstimates?.Add(newItem);
                        sortedEstimates.Add(newItem);
                    }

                    for (int i = 0; i < 5; i++)
                    {
                        if (i < 4)
                        {
                            // Shift next value forward
                            sortedEstimates[i].Year = (sortedEstimates[i].Year ?? DateTime.Now.Year) + 1;
                            sortedEstimates[i].Value = sortedEstimates[i + 1].Value;
                        }
                        else
                        {
                            // Last slot gets zero 
                            sortedEstimates[i].Year = (sortedEstimates[i].Year ?? DateTime.Now.Year) + 1;
                            sortedEstimates[i].Value = 0.00m;
                        }
                    }
                }
            }

            logger.LogInformation("Successfully Forwarded Equipment Fundings");
            await capitalEquipmentRepository.UpdateRangeAsync(equipments);
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Fowarding Equipment Error: {Message}", ex.Message);
            throw new($"Fowarding Equipment Error: {ex.Message}");
        }
    }

    private async Task ForwardProjectFundingYears()
    {
        try
        {
            var spec = new SearchCapitalProjectsSpec();
            var projects = await capitalProjectRepository.ListAsync(spec);

            var allYears = await repository.ListAsync();
            int yearValue = DateTime.Now.Year;
            yearValue = allYears.Select(x => x.BudgetYear).Max();

            var category = (await repositoryCategory.ListAsync()).FirstOrDefault(x => x.Name == "request_status_project");
            var values = (await repositoryValue.ListAsync()).Where(x => x.LookupCategoryId == category.Id);
            var archivedStatus = values.FirstOrDefault(x => x.Name == "Archived")?.Id;
            var filteredProjects = projects.Where(x => x.GeneralInformation.RequestStatusId != archivedStatus.ToString());

            foreach (var project in filteredProjects)
            {
                project.BudgetId = (yearValue + 1).ToString();
                ProcessFundingList(project.BorrowingFundings);
                ProcessFundingList(project.OperatingFundings);
                ProcessFundingList(project.GrantFundings);
                ProcessFundingList(project.DonationFundings);
                ProcessFundingList(project.SpecialFundings);
                ProcessFundingList(project.OtherFundings);
                ProcessFundingList(project.SpendingBudgets);
            }

            logger.LogInformation("Successfully Forwarded Project Fundings");
            await capitalProjectRepository.UpdateRangeAsync(projects);
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Fowarding Project Error: {Message}", ex.Message);
            throw new($"Fowarding Project Error: {ex.Message}");
        }
    }

    private void ProcessFundingList(IEnumerable<dynamic>? fundings)
    {
        foreach (var funding in fundings ?? Enumerable.Empty<dynamic>())
        {
            var estimates = funding.YearEstimates as List<FundingYearItemProject> ?? new List<FundingYearItemProject>();

            var sortedEstimates = estimates
                .Where(y => y.Year != null)
                .OrderBy(y => y.Year)
                .ToList();

            var firstEstimate = sortedEstimates.FirstOrDefault();
            if (firstEstimate != null)
            {
                funding.YearRequested.Year = firstEstimate.Year;
                funding.YearRequested.Value = firstEstimate.Value;
            }

            while (sortedEstimates.Count < 5)
            {
                var newYear = (sortedEstimates.LastOrDefault()?.Year ?? DateTime.Now.Year) + 1;
                var newItem = new FundingYearItemProject
                {
                    Year = newYear,
                    Value = 0.00m
                };
                estimates.Add(newItem);
                sortedEstimates.Add(newItem);
            }

            for (int i = 0; i < 5; i++)
            {
                var currentYear = (sortedEstimates[i].Year ?? DateTime.Now.Year) + 1;
                sortedEstimates[i].Year = currentYear;

                if (i < 4)
                    sortedEstimates[i].Value = sortedEstimates[i + 1].Value;
                else
                    sortedEstimates[i].Value = 0.00m;
            }
        }
    }

    private async Task<CreateBudgetYearResponse> GetResponseFromInsert(int year)
    {
        try
        {
            var item = BudgetYearItem.Create(year);
            await repository.AddAsync(item).ConfigureAwait(false);
            await repository.SaveChangesAsync().ConfigureAwait(false);
            logger.LogInformation("BudgetYear item created {BudgetYearItemId}", item.Id);
            return new CreateBudgetYearResponse(item.Id, "Budget Year Successfully Forwarded");
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "BudgetYear Error: {Message}", ex.Message);
            return new CreateBudgetYearResponse(null, "BudgetYear Error :" + ex.Message);
        }
    }

    private async Task CheckEquipmentRemainingFunding()
    {
        try
        {
            List<Guid> hasFutureFundingGuids = new List<Guid>();
            List<Guid> hasNoFutureFundingGuids = new List<Guid>();
            List<Guid> hasPastFundingGuids = new List<Guid>();
            List<Guid> hasNoPastFundingGuids = new List<Guid>();

            var equipments = await capitalEquipmentRepository.ListAsync();
            var equipmentFundings = await equipmentFundingRepository.ListAsync();
            var equipmentYearItems = await equipmentYearItemRepository.ListAsync();
            var category = (await repositoryCategory.ListAsync()).FirstOrDefault(x => x.Name == "request_status");
            var values = (await repositoryValue.ListAsync()).Where(x => x.LookupCategoryId == category.Id);

            var approvedStatus = values.FirstOrDefault(x => x.Name == "Approved by Finance")?.Id;
            var filteredEquipments = equipments.Where(x => x.RequestStatusId == approvedStatus.ToString());
            foreach (var equipment in filteredEquipments)
            {
                var fundings = equipment?.FundingItems?.Select(x => new FundingItemSummation()
                {
                    Type = x.FundingType,
                    CurrentYear = x.CurrentYearRequested.Value,
                    FutureYears = x.YearEstimates
                        .Where(f => f.Year > x.CurrentYearRequested.Year)
                        .Select(f => f.Value.GetValueOrDefault()).Sum()
                });

                var futureFundings = fundings?.Sum(x => x.FutureYears);
                var currentFundings = fundings?.Sum(x => x.CurrentYear);

                if (futureFundings > 0)
                {
                    hasFutureFundingGuids.Add(equipment.Id);
                }
                else
                {
                    hasNoFutureFundingGuids.Add(equipment.Id);
                }

                if (currentFundings > 0)
                {
                    hasPastFundingGuids.Add(equipment.Id);
                }
                else
                {
                    hasNoPastFundingGuids.Add(equipment.Id);
                }

            }

            //---PastFunding Insert
            var pastFundingEquipments = filteredEquipments.Where(x => hasPastFundingGuids.Contains(x.Id));
            foreach (var equipment in pastFundingEquipments)
            {
                equipment.PastFundings ??= new List<CapitalEquipment.Domain.PastFunding>();
                equipment.PastFundings.Clear();

                foreach (var ef in equipment.FundingItems ?? Enumerable.Empty<FundingItem>())
                {
                    if (ef.CurrentYearRequested?.Year != null && ef.CurrentYearRequested.Value > 0)
                    {
                        var pastFunding = new PastFundingCreateDTO()
                        {
                            Details = "",
                            Year = ef.CurrentYearRequested.Year,
                            Amount = ef.CurrentYearRequested.Value,
                            Request = equipment.RequestId.ToString(),
                            SOF = ef.FundingType,
                            FundingSource = ef.FundingSource,
                            FundingSubSource = ef.FundingSource,
                        };
                        equipment.PastFundings.Add(pastFunding.Adapt<CapitalEquipment.Domain.PastFunding>());
                    }
                }
            }

            logger.LogInformation("Successfully added equipment past funding records.");
            await capitalEquipmentRepository.UpdateRangeAsync(pastFundingEquipments);

            //---Update Statuses
            var requiresDepartmentReviewStatus = values.FirstOrDefault(x => x.Name == "Requires Department Review")?.Id;
            var archivedStatus = values.FirstOrDefault(x => x.Name == "Archived")?.Id;

            var futureFundingEquipments = filteredEquipments.Where(x => hasFutureFundingGuids.Contains(x.Id));
            foreach (var equipment in futureFundingEquipments)
            {
                equipment.RequestStatusId = requiresDepartmentReviewStatus.ToString();
            }

            var noFutureFundingEquipments = filteredEquipments.Where(x => hasNoFutureFundingGuids.Contains(x.Id));
            foreach (var equipment in noFutureFundingEquipments)
            {
                equipment.RequestStatusId = archivedStatus.ToString();
                equipment.FundingItems.Clear();
            }

            var updatedEquipments = futureFundingEquipments.Concat(noFutureFundingEquipments);
            logger.LogInformation("Successfully updated equipment statuses.");
            await capitalEquipmentRepository.UpdateRangeAsync(updatedEquipments);

        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Updating Equipment Statuses Error: {Message}", ex.Message);
            throw new($"Updating Equipment Statuses Error: {ex.Message}");
        }
    }

    private async Task CheckProjectRemainingFunding()
    {
        try
        {
            List<Guid> hasFutureFundingGuids = new List<Guid>();
            List<Guid> hasNoFutureFundingGuids = new List<Guid>();
            List<Guid> hasPastFundingGuids = new List<Guid>();
            List<Guid> hasNoPastFundingGuids = new List<Guid>();
            List<Guid> hasPastSpendingFundingGuids = new List<Guid>();
            List<Guid> hasNoPastSpendingFundingGuids = new List<Guid>();

            var spec = new SearchCapitalProjectsSpec();
            var projects = await capitalProjectRepository.ListAsync(spec);
            var category = (await repositoryCategory.ListAsync()).FirstOrDefault(x => x.Name == "request_status_project");
            var values = (await repositoryValue.ListAsync()).Where(x => x.LookupCategoryId == category.Id);

            var approvedStatus = values.FirstOrDefault(x => x.Name == "Approved by Finance")?.Id;
            var filteredProjects = projects.Where(x => x.GeneralInformation.RequestStatusId == approvedStatus.ToString());

            foreach (var project in filteredProjects)
            {

                var borrowingFundings = project.BorrowingFundings?.Select(x => new FundingItemSummation()
                {
                    CurrentYear = x.YearRequested?.Value!.Value,
                    FutureYears = x.YearEstimates?
                        .Where(f => f.Year > Int32.Parse(project.BudgetId))
                        .Select(f => f.Value).Sum()
                });

                var operatingFundings = project.OperatingFundings?.Select(x => new FundingItemSummation()
                {
                    CurrentYear = x.YearRequested?.Value!.Value,
                    FutureYears = x.YearEstimates?
                        .Where(f => f.Year > Int32.Parse(project.BudgetId))
                        .Select(f => f.Value).Sum()
                });

                var grantFundings = project.GrantFundings?.Select(x => new FundingItemSummation()
                {
                    CurrentYear = x.YearRequested?.Value!.Value,
                    FutureYears = x.YearEstimates?
                        .Where(f => f.Year > Int32.Parse(project.BudgetId))
                        .Select(f => f.Value).Sum()
                });

                var donationFundings = project.DonationFundings?.Select(x => new FundingItemSummation()
                {
                    CurrentYear = x.YearRequested?.Value!.Value,
                    FutureYears = x.YearEstimates?
                        .Where(f => f.Year > Int32.Parse(project.BudgetId))
                        .Select(f => f.Value).Sum()
                });

                var specialFundings = project.SpecialFundings?.Select(x => new FundingItemSummation()
                {
                    CurrentYear = x.YearRequested?.Value!.Value,
                    FutureYears = x.YearEstimates?
                        .Where(f => f.Year > Int32.Parse(project.BudgetId))
                        .Select(f => f.Value).Sum()
                });

                var otherFundings = project.OtherFundings?.Select(x => new FundingItemSummation()
                {
                    CurrentYear = x.YearRequested?.Value!.Value,
                    FutureYears = x.YearEstimates?
                        .Where(f => f.Year > Int32.Parse(project.BudgetId))
                        .Select(f => f.Value).Sum()
                });

                var spendingFundings = project.SpendingBudgets?.Select(x => new FundingItemSummation()
                {
                    CurrentYear = x.YearRequested?.Value!.Value,
                    FutureYears = x.YearEstimates?
                       .Where(f => f.Year > Int32.Parse(project.BudgetId))
                       .Select(f => f.Value).Sum()
                });

                var fundings = new List<FundingItemSummation>()
                    .Concat(borrowingFundings ?? new List<FundingItemSummation>())
                    .Concat(operatingFundings ?? new List<FundingItemSummation>())
                    .Concat(grantFundings ?? new List<FundingItemSummation>())
                    .Concat(donationFundings ?? new List<FundingItemSummation>())
                    .Concat(otherFundings ?? new List<FundingItemSummation>())
                    .Concat(specialFundings ?? new List<FundingItemSummation>())
                    .Concat(spendingFundings ?? new List<FundingItemSummation>());

                var futureFundings = fundings?.Sum(x => x.FutureYears);
                var currentFundings = fundings?.Sum(x => x.CurrentYear);
                var currentSpendingFundings = spendingFundings?.Sum(x => x.CurrentYear);

                if (futureFundings > 0)
                {
                    hasFutureFundingGuids.Add(project.Id);
                }
                else
                {
                    hasNoFutureFundingGuids.Add(project.Id);
                }

                if (currentFundings > 0)
                {
                    hasPastFundingGuids.Add(project.Id);
                }
                else
                {
                    hasNoPastFundingGuids.Add(project.Id);
                }

                if (currentSpendingFundings > 0)
                {
                    hasPastSpendingFundingGuids.Add(project.Id);
                }
                else
                {
                    hasNoPastSpendingFundingGuids.Add(project.Id);
                }
            }

            //---PastFunding Insert
            var pastFundingProjects = filteredProjects.Where(x => hasPastFundingGuids.Contains(x.Id));
            foreach (var project in pastFundingProjects)
            {
                project.PastFundings ??= new List<CapitalProject.Domain.PastFunding>();
                project.PastFundings.Clear();

                AddPastFundings(project, project.BorrowingFundings, "Borrowing", useDescription: false);
                AddPastFundings(project, project.OperatingFundings, "Operating", useDescription: false);
                AddPastFundings(project, project.GrantFundings, "Grant", useDescription: true);
                AddPastFundings(project, project.DonationFundings, "Outside", useDescription: false);
                AddPastFundings(project, project.SpecialFundings, "Special", useDescription: false);
                AddPastFundings(project, project.OtherFundings, "Other", useDescription: true);
            }
            logger.LogInformation("Successfully added project past funding records.");
            await capitalProjectRepository.UpdateRangeAsync(pastFundingProjects);

            //---PastSpending Insert
            var pastSpendingFundingProjects = filteredProjects.Where(x => hasPastSpendingFundingGuids.Contains(x.Id));
            foreach (var spending in pastSpendingFundingProjects)
            {
                spending.PastSpendings ??= new List<CapitalProject.Domain.PastSpending>();
                spending.PastSpendings.Clear();

                foreach (var sb in spending.SpendingBudgets ?? Enumerable.Empty<SpendingBudget>())
                {
                    if (sb.YearRequested?.Year != null && sb.YearRequested.Value > 0)
                    {
                        var pastSpending = new PastSpendingDTO()
                        {
                            ExpenditureCategoryId = sb.ExpenditureCategoryId,
                            Details = "",
                            Year = sb.YearRequested.Year,
                            Amount = sb.YearRequested.Value,
                            CIPItemNumber = spending?.RequestId.ToString(),
                            SpendingPurposeId = sb.SpendingPurposeId,
                        };
                        spending.PastSpendings.Add(pastSpending.Adapt<CapitalProject.Domain.PastSpending>());
                    }
                }
            }

            logger.LogInformation("Successfully added past spending records.");
            await capitalProjectRepository.UpdateRangeAsync(pastSpendingFundingProjects);


            //---Update Statuses
            var requiresDepartmentReviewStatus = values.FirstOrDefault(x => x.Name == "Requires Department Review")?.Id;
            var archivedStatus = values.FirstOrDefault(x => x.Name == "Archived")?.Id;

            var futureFundingProjects = filteredProjects.Where(x => hasFutureFundingGuids.Contains(x.Id));
            foreach (var project in futureFundingProjects)
            {
                project.GeneralInformation.RequestStatusId = requiresDepartmentReviewStatus.ToString();
            }

            var noFutureFundingProjects = filteredProjects.Where(x => hasNoFutureFundingGuids.Contains(x.Id));
            foreach (var project in noFutureFundingProjects)
            {
                project.GeneralInformation.RequestStatusId = archivedStatus.ToString();
                project.BorrowingFundings.Clear();
                project.OperatingFundings.Clear();
                project.GrantFundings.Clear();
                project.DonationFundings.Clear();
                project.SpecialFundings.Clear();
                project.OtherFundings.Clear();
                project.SpendingBudgets.Clear();
            }

            var updatedProjects = futureFundingProjects.Concat(noFutureFundingProjects);
            logger.LogInformation("Successfully updated project statuses.");
            await capitalProjectRepository.UpdateRangeAsync(updatedProjects);
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Updating Project Statuses Error: {Message}", ex.Message);
            throw new($"Updating Project Statuses Error: {ex.Message}");
        }
    }
    private void AddPastFundings<TFunding>(CapitalProjectItem project, IEnumerable<TFunding>? fundings, string source, bool useDescription)
    {
        foreach (var funding in fundings ?? Enumerable.Empty<TFunding>())
        {
            dynamic f = funding!;
            var yearRequested = f?.YearRequested;

            if (yearRequested != null && yearRequested.Year != null && yearRequested.Value > 0)
            {
                int year = yearRequested.Year;

                var pastFunding = new PastFundingDTO
                {
                    ExpenditureCategoryId = f.ExpenditureCategoryId,
                    SourceOfFunds = source,
                    Details = useDescription ? f.Description ?? "" : "",
                    Year = year,
                    Amount = yearRequested.Value,
                    CIPItemNumber = project.RequestId.ToString(),
                    FundingSourceId = f.FundingSourceId,
                    FundingSubSourceId = f.FundingSourceId
                };

                project.PastFundings.Add(pastFunding.Adapt<CapitalProject.Domain.PastFunding>());
            }
        }
    }
    private class FundingItemSummation
    {
        public Decimal? CurrentYear { get; set; }
        public Decimal? FutureYears { get; set; }
        public string? Type { get; set; }
    }
    public class PastFundingCreateDTO
    {
        public Guid Id { get; set; }
        public string? Details { get; set; }
        public int? Year { get; set; }
        public decimal? Amount { get; set; }
        public string? Request { get; set; }
        public Guid? FundingSource { get; set; } = Guid.Empty;
        public Guid? FundingSubSource { get; set; } = Guid.Empty;
        public string? SOF { get; set; }
    }
    public class PastFundingDTO
    {
        public Guid Id { get; set; }
        public Guid? ExpenditureCategoryId { get; set; }
        public string? ExpenditureCategoryName { get; set; }
        public string? SourceOfFunds { get; set; }
        public string? Details { get; set; }
        public int? Year { get; set; }
        public decimal? Amount { get; set; }
        public string? CIPItemNumber { get; set; }
        public Guid? FundingSourceId { get; set; }
        public string? FundingSourceName { get; set; }
        public Guid? FundingSubSourceId { get; set; }
        public string? FundingSubSourceName { get; set; }
    }
    public class PastSpendingDTO
    {
        public Guid Id { get; set; }
        public Guid? ExpenditureCategoryId { get; set; }
        public string? ExpenditureCategoryName { get; set; }
        public Guid? SpendingPurposeId { get; set; } = Guid.Empty;
        public string? SpendingPurposeName { get; set; }
        public string? Details { get; set; }
        public int? Year { get; set; }
        public decimal? Amount { get; set; }
        public string? CIPItemNumber { get; set; }
    }
}
