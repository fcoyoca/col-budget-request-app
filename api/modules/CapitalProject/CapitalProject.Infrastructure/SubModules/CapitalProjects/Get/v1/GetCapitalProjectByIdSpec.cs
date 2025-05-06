using Ardalis.Specification;
using budget_request_app.WebApi.CapitalProject.Domain;

namespace budget_request_app.WebApi.CapitalProject.Infrastructure.SubModules.CapitalProjects.Get.v1;

public class GetCapitalProjectByIdSpec : Specification<CapitalProjectItem>
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

            .Include(x => x.BorrowingFundings)
            
            .Include(x => x.OperatingFundings)
            .Include(x => x.GrantFundings)
            .Include(x => x.DonationFundings)
            .Include(x => x.SpecialFundings)
            .Include(x => x.OtherFundings)
            .Include(x => x.SpendingBudgets)
            .Include(x => x.FundingChanges)
            .Include(x => x.PastFundings)
            .Include(x => x.PastSpendings)
            .Include(x => x.ProjectManagement)
            .AsSplitQuery();

    }
}
