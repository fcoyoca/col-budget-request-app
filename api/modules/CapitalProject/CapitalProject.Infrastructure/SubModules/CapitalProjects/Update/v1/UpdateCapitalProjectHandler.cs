using FSH.Framework.Core.Persistence;
using budget_request_app.WebApi.CapitalProject.Domain;
using Mapster;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.CapitalProject.Infrastructure.SubModules.CapitalProjects.Update.v1;
public sealed class UpdateCapitalProjectHandler(
    ILogger<UpdateCapitalProjectHandler> logger,
    [FromKeyedServices("capitalProjects")] IRepository<CapitalProjectItem> repository)
    : IRequestHandler<UpdateCapitalProjectCommand, UpdateCapitalProjectResponse>
{
    public async Task<UpdateCapitalProjectResponse> Handle(UpdateCapitalProjectCommand request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        
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
        var donationFundingIsDonatedFundsUsed = request.Financial?.Funding?.DonationFunding?.DonationFundingIsDonatedFundsUsed;
        var donationFundingIsContributeFundsRequired = request.Financial?.Funding?.DonationFunding?.DonationFundingIsContributeFundsRequired;
        var donationFundings = request.Financial?.Funding?.DonationFunding?.DonationFundings;
        var specialFundings = request.Financial?.Funding?.SpecialFundings;
        var otherFundings = request.Financial?.Funding?.OtherFundings;
        var spendingBudgets = request.Financial?.Spending?.SpendingBudgets;
        var fundingChanges = request.Financial?.Change?.FundingChanges;
        var pastFundings = request.Financial?.Past?.PastFundings;
        var pastSpendings = request.Financial?.Past?.PastSpendings;
        var projectManagement = request.ProjectManagement;

        var capitalProject = new CapitalProjectItem()
        {
            BudgetId = request.BudgetId,
            RevisionTitle = request.RevisionTitle,
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
            DonationFundings = donationFundings.Adapt<List<DonationFunding>>(),
            SpecialFundings = specialFundings.Adapt<List<SpecialFunding>>(),
            OtherFundings = otherFundings.Adapt<List<OtherFunding>>(),
            SpendingBudgets = spendingBudgets.Adapt<List<SpendingBudget>>(),
            FundingChanges = fundingChanges.Adapt<List<FundingChange>>(),
            PastFundings = pastFundings.Adapt<List<PastFunding>>(),
            PastSpendings = pastSpendings.Adapt<List<PastSpending>>(),
            ProjectManagement = projectManagement.Adapt<ProjectManagement>()
        };
        
        await repository.AddAsync(capitalProject, cancellationToken);
        logger.LogInformation("CapitalProject created {CapitalProjectId}", capitalProject.Id);
        return new UpdateCapitalProjectResponse(capitalProject.Id, "Kimper success!!");
    }
}
