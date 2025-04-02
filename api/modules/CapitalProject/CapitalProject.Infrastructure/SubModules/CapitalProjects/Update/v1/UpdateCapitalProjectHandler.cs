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

        var capitalProject = await repository.GetByIdAsync(request.Id, cancellationToken);

        capitalProject.BudgetId = request.BudgetId;
        capitalProject.RevisionTitle = request.RevisionTitle;
        capitalProject.GeneralInformation = request.GeneralInformation?.Adapt<GeneralInformation>();
        capitalProject.JustificationPrioritization = justificationPrioritization.Adapt<JustificationPrioritization>();
        capitalProject.StatusTimeline = statusTimeline.Adapt<StatusTimeline>();
        capitalProject.ApprovalOversight = approvalOversight.Adapt<ApprovalOversight>();
        capitalProject.GrantFundingOpportunity = grantFundingOpportunity.Adapt<GrantFundingOpportunity>();
        capitalProject.OperatingCosts = operatingCosts.Adapt<List<OperatingCost>>();
        capitalProject.OperatingRevenues = operatingRevenues.Adapt<List<OperatingRevenue>>();
        capitalProject.IsMappedRequest = request.MinorProjectLocation?.RequestLocation?.IsMappedRequest;
        capitalProject.GISMappingDescription = request.MinorProjectLocation?.RequestLocation?.GISMappingDescription;
        capitalProject.MinorProjects = minorProjects.Adapt<List<MinorProject>>();
        capitalProject.StreetSegments = streetSegments.Adapt<List<StreetSegment>>();
        capitalProject.TIFFundingIds = tifFundingIds;
        capitalProject.BorrowingFundings = borrowingFundings.Adapt<List<BorrowingFunding>>();
        capitalProject.OperatingFundings = operatingFundings.Adapt<List<OperatingFunding>>();
        capitalProject.GrantFundings = grantFundings.Adapt<List<GrantFunding>>();
        capitalProject.DonationFundingIsDonatedFundsUsed = donationFundingIsDonatedFundsUsed;
        capitalProject.DonationFundingIsContributeFundsRequired = donationFundingIsContributeFundsRequired;
        capitalProject.DonationFundings = donationFundings.Adapt<List<DonationFunding>>();
        capitalProject.SpecialFundings = specialFundings.Adapt<List<SpecialFunding>>();
        capitalProject.OtherFundings = otherFundings.Adapt<List<OtherFunding>>();
        capitalProject.SpendingBudgets = spendingBudgets.Adapt<List<SpendingBudget>>();
        capitalProject.FundingChanges = fundingChanges.Adapt<List<FundingChange>>();
        capitalProject.PastFundings = pastFundings.Adapt<List<PastFunding>>();
        capitalProject.PastSpendings = pastSpendings.Adapt<List<PastSpending>>();
        capitalProject.ProjectManagement = projectManagement.Adapt<ProjectManagement>();
        
        await repository.UpdateAsync(capitalProject, cancellationToken);
        logger.LogInformation("CapitalProject created {CapitalProjectId}", capitalProject.Id);
        return new UpdateCapitalProjectResponse(capitalProject.Id, "Kimper success!!");
    }
}
