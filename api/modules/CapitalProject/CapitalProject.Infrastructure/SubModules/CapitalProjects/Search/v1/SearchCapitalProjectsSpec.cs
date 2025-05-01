using Ardalis.Specification;
using budget_request_app.WebApi.CapitalProject.Domain;
using budget_request_app.WebApi.CapitalProject.Infrastructure.SubModules.CapitalProjects.Search.v1;
using FSH.Framework.Core.Paging;
using FSH.Framework.Core.Specifications;

namespace budget_request_app.WebApi.CapitalProject.Infrastructure.SubModules.CapitalProjects.Get.v1;

public class SearchCapitalProjectsSpec : EntitiesByPaginationFilterSpec<CapitalProjectItem>
{
    public SearchCapitalProjectsSpec(SearchCapitalProjectsCommand command)
        : base(command) =>
        Query
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
            .Where(x => x.Id == Guid.Parse("26109f84-54f4-40f0-a319-3f9404ddd545"));
}
