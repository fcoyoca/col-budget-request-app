using System.Runtime.InteropServices.JavaScript;
using budget_request_app.WebApi.CapitalEquipment.Domain;
using budget_request_app.WebApi.CapitalEquipment.Domain.Exceptions;
using budget_request_app.WebApi.CapitalEquipment.Infrastructure.SubModules.CapitalEquipments.Create.v1;
using budget_request_app.WebApi.CapitalEquipment.Infrastructure.SubModules.CapitalEquipments.Get.v1;
using FSH.Framework.Core.Persistence;
using Mapster;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.CapitalEquipment.Infrastructure.SubModules.CapitalEquipments.Update.v1;
public sealed class UpdateCapitalEquipmentHandler(
    ILogger<UpdateCapitalEquipmentHandler> logger,
    [FromKeyedServices("capitalEquipments")] IRepository<CapitalEquipmentItem> repository,
    [FromKeyedServices("capitalEquipmentsFundingItems")] IRepository<FundingItem> repositoryFundingItem,
    [FromKeyedServices("capitalEquipmentsPastFundings")] IRepository<PastFunding> repositoryPastFunding)
    : IRequestHandler<UpdateCapitalEquipmentCommand, UpdateCapitalEquipmentResponse>
{
    public async Task<UpdateCapitalEquipmentResponse> Handle(UpdateCapitalEquipmentCommand request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        var capitalEquipment = await repository.FirstOrDefaultAsync(new GetCapitalEquipmentByIdSpec(request.Id), cancellationToken);
        _ = capitalEquipment ?? throw new CapitalEquipmentNotFoundException(request.Id);
        
        GeneralInfo generalInfo = new GeneralInfo();
        EquipmentInfo equipmentInfo = new EquipmentInfo();
        JustificationPrioritization justificationPrioritization = new JustificationPrioritization();
        JustificationMatrix justificationMatrix = new JustificationMatrix();
        ExistingAssetInfo existingAssetInfo = new ExistingAssetInfo();
        OperatingBudgetImpact operatingBudgetImpact = new OperatingBudgetImpact();
        ApprovalOversightInfo approvalOversightInfo = new ApprovalOversightInfo();
        List<FundingItem> fundingItems = new List<FundingItem>();
        
        generalInfo = request.GeneralInfo;
        equipmentInfo = request.EquipmentInfo;
        justificationPrioritization = request.JustificationPrioritization;
        justificationMatrix = request.JustificationMatrix;
        existingAssetInfo = request.ExistingAssetInfo;
        operatingBudgetImpact = request.OperatingBudgetImpact;
        approvalOversightInfo = request.ApprovalOversightInfo;
        
        var borrowingFundings = FundingItemMapper.MapFundingItems(request.Funding.BorrowingFundings, FundingTab.Borrowing);
        var oueFundings = FundingItemMapper.MapFundingItems(request.Funding.OUEFundings, FundingTab.Operating);
        var grantFundings = FundingItemMapper.MapFundingItems(request.Funding.GrantFundings, FundingTab.Grant);
        var outsideFundings = FundingItemMapper.MapFundingItems(request.Funding.OutsideFundings, FundingTab.Outside);
        var specialFundings = FundingItemMapper.MapFundingItems(request.Funding.SpecialFundings, FundingTab.Special);
        var otherFundings = FundingItemMapper.MapFundingItems(request.Funding.OtherFundings, FundingTab.Other);
        
        var capitalEquipmentFundingItems = await repositoryFundingItem.ListAsync();
        var items = capitalEquipmentFundingItems.Where(x => x.CapitalEquipmentId == request.Id).ToList();
        await repositoryFundingItem.DeleteRangeAsync(items, cancellationToken);
        
        fundingItems = new List<FundingItem>();
        fundingItems.AddRange(borrowingFundings);
        fundingItems.AddRange(oueFundings);
        fundingItems.AddRange(grantFundings);
        fundingItems.AddRange(outsideFundings);
        fundingItems.AddRange(specialFundings);
        fundingItems.AddRange(otherFundings);
        
        foreach (FundingItem fundingItem in fundingItems)
        {
            fundingItem.CapitalEquipmentId = request.Id;
        }
        
        await repositoryFundingItem.AddRangeAsync(fundingItems, cancellationToken);
        
        capitalEquipment.PastFundings.Clear();
        
        var updatedCapitalEquipment = CapitalEquipmentItem.Update(
            capitalEquipment,
            request.BudgetId,
            request.RevisionTitle,
            request.RequestId,
            request.Title,
            generalInfo.RequestStatusId,
            generalInfo.RemarksPrintout,
            generalInfo.RequestingDepartmentIds,
            generalInfo.DepartmentHeadRequestorId,
            generalInfo.EquipmentName,
            generalInfo.EquipmentCategoryId,
            equipmentInfo.IsNew,
            equipmentInfo.IsReplacement,
            equipmentInfo.IsLeasedVehicle,
            equipmentInfo.Quantity,
            equipmentInfo.UnitCost,
            equipmentInfo.EquipmentSummary,
            justificationPrioritization.DepartmentPriorityRanking,
            justificationPrioritization.ExpectedOutcomes,
            justificationPrioritization.PurposeOfExpenditure,
            justificationPrioritization.JustificationForReplacement,
            justificationMatrix.RequiredMandatedPriority,
            justificationMatrix.SafetyPriority,
            justificationMatrix.PaybackPeriodPriority,
            justificationMatrix.SustainabilityPriority,
            justificationMatrix.CostToOperatePriority,
            justificationMatrix.RevenueGenerationPriority,
            justificationMatrix.RequiredMandatedExplanation,
            justificationMatrix.SafetyExplanation,
            justificationMatrix.PaybackPeriodExplanation,
            justificationMatrix.SustainabilityExplanation,
            justificationMatrix.CostToOperateExplanation,
            justificationMatrix.RevenueGenerationExplanation,
            existingAssetInfo.AssetBeingReplaced,
            existingAssetInfo.ConditionOfAssetBeingReplaced,
            existingAssetInfo.OdometerReadingHours.ToString(),
            existingAssetInfo.StandardReplacementCycle,
            existingAssetInfo.EstimatedLifeOfEquipment,
            operatingBudgetImpact.DepartmentResponsibleForOperatingCosts,
            operatingBudgetImpact.AnnualOperatingCosts,
            operatingBudgetImpact.AnnualRevenueFromEquipment,
            approvalOversightInfo.HasPurchaseBeenApprovedByOversight,
            approvalOversightInfo.LegistarApprovalItemNumber,
            approvalOversightInfo.ApprovingOversightBoard.ToString(),
            approvalOversightInfo.DateOfOversightApproval,
            approvalOversightInfo.PurchasingBuyerReview,
            approvalOversightInfo.AdditionalNotes,
            request.FileIds
            );
        
        updatedCapitalEquipment.PastFundings.Clear();
        
        await repository.UpdateAsync(updatedCapitalEquipment, cancellationToken);

        var pastFundingChildren = request.Funding.PastFundings.Adapt<List<PastFunding>>();
        
        foreach (PastFunding pastFunding in pastFundingChildren)
        {
            pastFunding.CapitalEquipmentId = request.Id;
        }

        await repositoryPastFunding.AddRangeAsync(pastFundingChildren, cancellationToken);
        
        logger.LogInformation("CapitalEquipment with id : {CapitalEquipmentId} updated.", updatedCapitalEquipment.Id);
        
        return new UpdateCapitalEquipmentResponse(capitalEquipment.Id);
    }
}
