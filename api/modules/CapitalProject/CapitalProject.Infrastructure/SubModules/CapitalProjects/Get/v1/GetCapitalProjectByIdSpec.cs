using Ardalis.Specification;
using budget_request_app.WebApi.CapitalProject.Domain;

namespace budget_request_app.WebApi.CapitalProject.Infrastructure.SubModules.CapitalProjects.Get.v1;

public class GetCapitalProjectByIdSpec : Specification<CapitalProjectItem, CapitalProjectItem>
{
    public GetCapitalProjectByIdSpec(Guid id)
    {
        Query
            .Where(p => p.Id == id)
            .Include(x => x.GeneralInformation)

            .Include(x => x.JustificationPrioritization)
            .Include(x => x.StatusTimeline)
            .Include(x => x.GrantFundingOpportunity)
            .Include(x => x.ApprovalOversight)

            .Include(x => x.OperatingCosts)
            .Include(x => x.OperatingRevenues)

            .Include(x => x.MinorProjects)
            .Include(x => x.StreetSegments)

            // .Include(x => x.BorrowingFundings)
            // .ThenInclude(x => x.YearRequested)
            // .Include(x => x.BorrowingFundings)
            // .ThenInclude(x => x.YearEstimates)
            //
            // .Include(x => x.OperatingFundings)
            // .ThenInclude(x => x.YearRequested)
            // .Include(x => x.OperatingFundings)
            // .ThenInclude(x => x.YearEstimates)
            //
            // .Include(x => x.GrantFundings)
            // .ThenInclude(x => x.YearRequested)
            // .Include(x => x.GrantFundings)
            // .ThenInclude(x => x.YearEstimates)
            //
            // .Include(x => x.DonationFundings)
            // .ThenInclude(x => x.YearRequested)
            // .Include(x => x.DonationFundings)
            // .ThenInclude(x => x.YearEstimates)
            //
            // .Include(x => x.SpecialFundings)
            // .ThenInclude(x => x.YearRequested)
            // .Include(x => x.SpecialFundings)
            // .ThenInclude(x => x.YearEstimates)
            //
            // .Include(x => x.OtherFundings)
            // .ThenInclude(x => x.YearRequested)
            // .Include(x => x.OtherFundings)
            // .ThenInclude(x => x.YearEstimates)
            //
            // .Include(x => x.SpendingBudgets)
            // .ThenInclude(x => x.YearRequested)
            // .Include(x => x.SpendingBudgets)
            // .ThenInclude(x => x.YearEstimates)
            //
            // .Include(x => x.FundingChanges)
            // .Include(x => x.PastFundings)
            // .Include(x => x.PastSpendings)
            
        .Include(x => x.ProjectManagement);

    }
}
