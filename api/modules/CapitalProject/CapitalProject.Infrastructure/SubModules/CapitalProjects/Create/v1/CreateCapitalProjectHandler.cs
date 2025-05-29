using budget_request_app.WebApi.BudgetYear.Domain;
using FSH.Framework.Core.Persistence;
using budget_request_app.WebApi.CapitalProject.Domain;
using FSH.Framework.Core.Exceptions;
using Mapster;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.CapitalProject.Infrastructure.SubModules.CapitalProjects.Create.v1;
public sealed class CreateCapitalProjectHandler(
    ILogger<CreateCapitalProjectHandler> logger,
    [FromKeyedServices("capitalProjects")] IRepository<CapitalProjectItem> repository,
    [FromKeyedServices("budgetYears")] IRepository<BudgetYearItem> budgetYearRepository)
    : IRequestHandler<CreateCapitalProjectCommand, CreateCapitalProjectResponse>
{
    public async Task<CreateCapitalProjectResponse> Handle(CreateCapitalProjectCommand request, CancellationToken cancellationToken)
    {
        var budgetYears = await budgetYearRepository.ListAsync();

        if (budgetYears.Count == 0)
        {
            throw new NotFoundException("budget year not found");
        }

        ArgumentNullException.ThrowIfNull(request);
        
        var maxBudgetYear = budgetYears.Select(x => x.BudgetYear).Max();

        var donationFundingParent = request.Financial?.Funding?.DonationFunding;
        
        var justificationPrioritization = request.TimeJustificationApproval?.JustificationPrioritization;
        var statusTimeline = request.TimeJustificationApproval?.StatusTimeline;
        var approvalOversight = request.TimeJustificationApproval?.ApprovalOversight;
        var grantFundingOpportunity = request.TimeJustificationApproval?.GrantFundingOpportunity;
        var operatingCosts = request.OperatingBudgetImpact?.OperatingCosts;
        var operatingRevenues = request.OperatingBudgetImpact?.OperatingRevenues;
        var minorProjects = request.MinorProjectLocation?.MinorProjects;
        var streetSegments = request.MinorProjectLocation?.StreetSegments;
        var tifFundingIds = request.Financial?.Funding?.TIFFundingIds;
        var borrowingFundings = request.Financial?.Funding?.BorrowingFundings;
        var operatingFundings = request.Financial?.Funding?.OperatingFundings;
        var grantFundings = request.Financial?.Funding?.GrantFundings;
        var donationFundingIsDonatedFundsUsed = donationFundingParent?.DonationFundingIsDonatedFundsUsed;
        var donationFundingIsContributeFundsRequired = donationFundingParent?.DonationFundingIsContributeFundsRequired;
        var amountAdvanced = donationFundingParent?.AmountAdvanced;
        var advancedFundsDescription = donationFundingParent?.AdvancedFundsDescription;
        var donatedAmountCollected = donationFundingParent?.DonatedAmountCollected;
        var amountDonated = donationFundingParent?.AmountDonated;
        var donationArrangements = donationFundingParent?.DonationArrangements;
        var donationFundings = donationFundingParent?.DonationFundings;
        var specialFundings = request.Financial?.Funding?.SpecialFundings;
        var otherFundings = request.Financial?.Funding?.OtherFundings;
        var spendingBudgets = request.Financial?.Spending?.SpendingBudgets;
        var fundingChanges = request.Financial?.Change?.FundingChanges;
        var pastFundings = request.Financial?.Past?.PastFundings;
        var pastSpendings = request.Financial?.Past?.PastSpendings;
        var projectManagement = request.ProjectManagement;
        
        var allProjectRequests = await repository.ListAsync();

        int requestId = 1;
        int requestNumber = 0;

        if (allProjectRequests.Any())
        {
            var currentYearRequests = allProjectRequests
                .Where(x => x.BudgetId.ToString() == maxBudgetYear.ToString());

            if (currentYearRequests.Any())
            {
                requestId = currentYearRequests
                    .Select(x => x.RequestId)
                    .Max() + 1;
                
                requestNumber = currentYearRequests
                    .Select(x => x.RequestNumber ?? 0)
                    .Max() + 1;
            }
        }
        
        var projectNumber = ( maxBudgetYear % 100 ) + "-" + (requestNumber % 1000).ToString("D3");

        var capitalProject = new CapitalProjectItem()
        {
            RequestNumber = requestNumber,
            ProjectNumber = request.ProjectNumber,
            BudgetId = maxBudgetYear.ToString(),
            RevisionTitle = request.RevisionTitle,
            RequestId = requestId,
            GeneralInformation = request.GeneralInformation?.Adapt<GeneralInformation>(),
            JustificationPrioritization = justificationPrioritization.Adapt<JustificationPrioritization>(),
            StatusTimeline = statusTimeline.Adapt<StatusTimeline>(),
            ApprovalOversight = approvalOversight.Adapt<ApprovalOversight>(),
            GrantFundingOpportunity = grantFundingOpportunity.Adapt<GrantFundingOpportunity>(),
            OperatingCosts = operatingCosts.Adapt<List<OperatingCost>>(),
            OperatingRevenues = operatingRevenues.Adapt<List<OperatingRevenue>>(),
            IsMappedRequest = request.MinorProjectLocation?.RequestLocation?.IsMappedRequest,
            GISMappingDescription = request.MinorProjectLocation?.RequestLocation?.GISMappingDescription,
            MinorProjects = minorProjects.Adapt<List<MinorProject>>(),
            StreetSegments = streetSegments.Adapt<List<StreetSegment>>(),
            TIFFundingIds = tifFundingIds,
            BorrowingFundings = borrowingFundings.Adapt<List<BorrowingFunding>>(),
            OperatingFundings = operatingFundings.Adapt<List<OperatingFunding>>(),
            GrantFundings = grantFundings.Adapt<List<GrantFunding>>(),
            DonationFundingIsDonatedFundsUsed = donationFundingIsDonatedFundsUsed,
            DonationFundingIsContributeFundsRequired = donationFundingIsContributeFundsRequired,
            AmountAdvanced = amountAdvanced,
            AdvancedFundsDescription = advancedFundsDescription,
            DonatedAmountCollected = donatedAmountCollected,
            AmountDonated = amountDonated,
            DonationArrangements = donationArrangements,
            DonationFundings = donationFundings.Adapt<List<DonationFunding>>(),
            SpecialFundings = specialFundings.Adapt<List<SpecialFunding>>(),
            OtherFundings = otherFundings.Adapt<List<OtherFunding>>(),
            SpendingBudgets = spendingBudgets.Adapt<List<SpendingBudget>>(),
            FundingChanges = fundingChanges.Adapt<List<FundingChange>>(),
            PastFundings = pastFundings.Adapt<List<PastFunding>>(),
            PastSpendings = pastSpendings.Adapt<List<PastSpending>>(),
            ProjectManagement = projectManagement.Adapt<ProjectManagement>(),
            FileIds = request.FileIds,
        };
        
        await repository.AddAsync(capitalProject, cancellationToken);
        logger.LogInformation("CapitalProject created {CapitalProjectId}", capitalProject.Id);
        return new CreateCapitalProjectResponse(capitalProject.Id, "Kimper success!!");
    }
}
