using Ardalis.Specification;
using budget_request_app.WebApi.CapitalProject.Domain;
using FSH.Framework.Core.Paging;
using FSH.Framework.Core.Specifications;

namespace budget_request_app.WebApi.BudgetYear.Features.Create.v1;

public class SearchCapitalProjectsSpec : Specification<CapitalProjectItem>
{
    public SearchCapitalProjectsSpec() =>
        Query
        .Include(x => x.GeneralInformation)

        .Include(x => x.BorrowingFundings)
            .ThenInclude(x => x.YearEstimates)
        .Include(x => x.BorrowingFundings)
            .ThenInclude(x => x.YearRequested)

        .Include(x => x.OperatingFundings)
            .ThenInclude(x => x.YearEstimates)
        .Include(x => x.OperatingFundings)
            .ThenInclude(x => x.YearRequested)

        .Include(x => x.GrantFundings)
            .ThenInclude(x => x.YearEstimates)
        .Include(x => x.GrantFundings)
            .ThenInclude(x => x.YearRequested)

        .Include(x => x.DonationFundings)
            .ThenInclude(x => x.YearEstimates)
        .Include(x => x.DonationFundings)
            .ThenInclude(x => x.YearRequested)

        .Include(x => x.SpecialFundings)
            .ThenInclude(x => x.YearEstimates)
        .Include(x => x.SpecialFundings)
            .ThenInclude(x => x.YearRequested)

        .Include(x => x.OtherFundings)
            .ThenInclude(x => x.YearEstimates)
        .Include(x => x.OtherFundings)
            .ThenInclude(x => x.YearRequested)

        .Include(x => x.SpendingBudgets)
            .ThenInclude(x => x.YearEstimates)
        .Include(x => x.SpendingBudgets)
            .ThenInclude(x => x.YearRequested)
        .AsSplitQuery();
    //.Where(x => x.Id == Guid.Parse("26109f84-54f4-40f0-a319-3f9404ddd545"));
}
