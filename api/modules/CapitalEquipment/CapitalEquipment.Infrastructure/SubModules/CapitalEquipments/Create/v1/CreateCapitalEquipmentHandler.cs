using FSH.Framework.Core.Persistence;
using budget_request_app.WebApi.CapitalEquipment.Domain;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.CapitalEquipment.Infrastructure.SubModules.CapitalEquipments.Create.v1;
public sealed class CreateCapitalEquipmentHandler(
    ILogger<CreateCapitalEquipmentHandler> logger,
    [FromKeyedServices("capitalEquipments")] IRepository<CapitalEquipmentItem> repository)
    : IRequestHandler<CreateCapitalEquipmentCommand, CreateCapitalEquipmentResponse>
{
    public async Task<CreateCapitalEquipmentResponse> Handle(CreateCapitalEquipmentCommand request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        
        GeneralInfo generalInfo = new GeneralInfo();
        EquipmentInfo equipmentInfo = new EquipmentInfo();
        JustificationPrioritization justificationPrioritization = new JustificationPrioritization();
        JustificationMatrix justificationMatrix = new JustificationMatrix();
        ExistingAssetInfo existingAssetInfo = new ExistingAssetInfo();
        OperatingBudgetImpact operatingBudgetImpact = new OperatingBudgetImpact();
        ApprovalOversightInfo approvalOversightInfo = new ApprovalOversightInfo();
        
        generalInfo = request.GeneralInfo;
        equipmentInfo = request.EquipmentInfo;
        justificationPrioritization = request.JustificationPrioritization;
        justificationMatrix = request.JustificationMatrix;
        existingAssetInfo = request.ExistingAssetInfo;
        operatingBudgetImpact = request.OperatingBudgetImpact;
        approvalOversightInfo = request.ApprovalOversightInfo;
        
        var data = CapitalEquipmentItem.Create(
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
            existingAssetInfo.OdometerReadingHours,
            existingAssetInfo.StandardReplacementCycle,
            existingAssetInfo.EstimatedLifeOfEquipment,
            operatingBudgetImpact.DepartmentResponsibleForOperatingCosts,
            operatingBudgetImpact.AnnualOperatingCosts,
            operatingBudgetImpact.AnnualRevenueFromEquipment,
            approvalOversightInfo.HasPurchaseBeenApprovedByOversight,
            approvalOversightInfo.LegistarApprovalItemNumber,
            approvalOversightInfo.ApprovingOversightBoard,
            approvalOversightInfo.DateOfOversightApproval,
            approvalOversightInfo.PurchasingBuyerReview,
            approvalOversightInfo.AdditionalNotes
            );
        
        await repository.AddAsync(data, cancellationToken);
        logger.LogInformation("CapitalEquipment created {CapitalEquipmentId}", data.Id);
        return new CreateCapitalEquipmentResponse(data.Id);
    }
}
