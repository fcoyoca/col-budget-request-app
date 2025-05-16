using System.Reflection;
using FSH.Framework.Core.Persistence;
using budget_request_app.WebApi.CapitalProject.Domain;
using budget_request_app.WebApi.CapitalProject.Infrastructure.SubModules.CapitalProjects.Get.v1;
using budget_request_app.WebApi.CapitalProject.Infrastructure.SubModules.CapitalProjects.Get.v1.DTOS;
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

        var capitalProject = await repository.FirstOrDefaultAsync(new GetCapitalProjectByIdSpec(request.Id), cancellationToken);

        capitalProject.MinorProjects = new List<MinorProject>();
        capitalProject.StreetSegments = new List<StreetSegment>();
        capitalProject.BorrowingFundings = new();
        capitalProject.OperatingFundings = new();
        capitalProject.GrantFundings = new();
        capitalProject.DonationFundings = new();
        capitalProject.SpecialFundings = new();
        capitalProject.OtherFundings = new();
        capitalProject.SpendingBudgets = new();
        capitalProject.FundingChanges = new();
        capitalProject.PastFundings = new();
        capitalProject.PastSpendings = new();
        capitalProject.OperatingCosts = new();
        capitalProject.OperatingRevenues = new();
        

        //await repository.SaveChangesAsync(cancellationToken);

        capitalProject.MinorProjects = minorProjects.Adapt<List<MinorProject>>();
        capitalProject.StreetSegments = streetSegments.Adapt<List<StreetSegment>>();
        capitalProject.BorrowingFundings = borrowingFundings.Adapt<List<BorrowingFunding>>();
        capitalProject.OperatingFundings = operatingFundings.Adapt<List<OperatingFunding>>();
        capitalProject.GrantFundings = grantFundings.Adapt<List<GrantFunding>>();
        capitalProject.DonationFundings = donationFundings.Adapt<List<DonationFunding>>();
        capitalProject.SpecialFundings = specialFundings.Adapt<List<SpecialFunding>>();
        capitalProject.OtherFundings = otherFundings.Adapt<List<OtherFunding>>();
        capitalProject.SpendingBudgets = spendingBudgets.Adapt<List<SpendingBudget>>();
        capitalProject.FundingChanges = fundingChanges.Adapt<List<FundingChange>>();
        capitalProject.PastFundings = pastFundings.Adapt<List<PastFunding>>();
        capitalProject.PastSpendings = pastSpendings.Adapt<List<PastSpending>>();

        capitalProject.OperatingCosts = operatingCosts.Adapt<List<OperatingCost>>();
        capitalProject.OperatingRevenues = operatingRevenues.Adapt<List<OperatingRevenue>>();
        
        capitalProject.RevisionTitle = request.RevisionTitle;
        
        CopyFields(request.GeneralInformation,capitalProject.GeneralInformation);
        CopyFields(justificationPrioritization, capitalProject.JustificationPrioritization);
        CopyFields(statusTimeline, capitalProject.StatusTimeline);
        CopyFields(approvalOversight, capitalProject.ApprovalOversight);
        CopyFields(grantFundingOpportunity, capitalProject.GrantFundingOpportunity);
        //CopyFields(minorProjects, capitalProject.MinorProjects);
        //CopyFields(streetSegments, capitalProject.StreetSegments);
        CopyFields(projectManagement, capitalProject.ProjectManagement);
        
        capitalProject.IsMappedRequest = request.MinorProjectLocation?.RequestLocation?.IsMappedRequest;
        capitalProject.GISMappingDescription = request.MinorProjectLocation?.RequestLocation?.GISMappingDescription;
        capitalProject.TIFFundingIds = tifFundingIds;
        capitalProject.DonationFundingIsDonatedFundsUsed = donationFundingIsDonatedFundsUsed;
        capitalProject.DonationFundingIsContributeFundsRequired = donationFundingIsContributeFundsRequired;
        capitalProject.AmountAdvanced = amountAdvanced;
        capitalProject.AdvancedFundsDescription = advancedFundsDescription;
        capitalProject.DonatedAmountCollected = donatedAmountCollected;
        capitalProject.AmountDonated = amountDonated;
        capitalProject.DonationArrangements = donationArrangements;
        
        capitalProject.FileIds = request.FileIds;
        
        await repository.UpdateAsync(capitalProject, cancellationToken);
        
        logger.LogInformation("CapitalProject updated {CapitalProjectId}", capitalProject.Id);
        return new UpdateCapitalProjectResponse(capitalProject.Id, "Kimper success!! " + capitalProject.TIFFundingIds );
    }
    
    public void CopyFields(dynamic source, dynamic target)
    {
        if (source == null || target == null)
            throw new ArgumentNullException();
        Type sourceType = source.GetType();
        Type targetType = target.GetType();

        var sourceFields = sourceType.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

        foreach (var field in sourceFields)
        {
            if (field.Name != "Id")
            {
                var targetField = targetType.GetField(field.Name, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
                if (targetField != null && targetField.FieldType == field.FieldType)
                {
                    var value = field.GetValue(source);
                    if (value != null)
                    {
                        targetField.SetValue(target, value);
                    }
                }
            }
        }
    }
}
