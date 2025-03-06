using Microsoft.Extensions.DependencyInjection;
using budget_request_app.WebApi.CapitalEquipment.Domain.Exceptions;
using FSH.Framework.Core.Persistence;
using FSH.Framework.Core.Caching;
using budget_request_app.WebApi.CapitalEquipment.Domain;
using budget_request_app.WebApi.CapitalEquipment.Infrastructure.SubModules.CapitalEquipments.Create.v1;
using MediatR;

namespace budget_request_app.WebApi.CapitalEquipment.Infrastructure.SubModules.CapitalEquipments.Get.v1;
public sealed class GetCapitalEquipmentHandler(
    [FromKeyedServices("capitalEquipments")] IReadRepository<CapitalEquipmentItem> repository,
    ICacheService cache)
    : IRequestHandler<GetCapitalEquipmentRequest, GetCapitalEquipmentResponse>
{
    public async Task<GetCapitalEquipmentResponse> Handle(GetCapitalEquipmentRequest request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);

        var item = await cache.GetOrSetAsync(
            $"CapitalEquipment:{request.Id}",
            async () =>
            {
                var capitalEquipmentItem = await repository.GetByIdAsync(request.Id, cancellationToken);
                if (capitalEquipmentItem == null) throw new CapitalEquipmentNotFoundException(request.Id);
                return Mapper(capitalEquipmentItem);
            },
            cancellationToken: cancellationToken);
        
        return item;
    }

    private GetCapitalEquipmentResponse Mapper(CapitalEquipmentItem capitalEquipmentItem)
    {
        GeneralInfo generalInfo = new GeneralInfo()
        {
            RequestStatusId = capitalEquipmentItem.RequestStatusId,
            RemarksPrintout = capitalEquipmentItem.RemarksPrintout,
            RequestingDepartmentIds = capitalEquipmentItem.RequestingDepartmentIds,
            DepartmentHeadRequestorId = capitalEquipmentItem.DepartmentHeadRequestorId,
            EquipmentName = capitalEquipmentItem.EquipmentName,
            EquipmentCategoryId = capitalEquipmentItem.EquipmentCategoryId,
        };

        EquipmentInfo equipmentInfo = new EquipmentInfo()
        {
            IsNew = capitalEquipmentItem.IsNew,
            IsReplacement = capitalEquipmentItem.IsReplacement,
            IsLeasedVehicle = capitalEquipmentItem.IsLeasedVehicle,
            Quantity = capitalEquipmentItem.Quantity,
            UnitCost = capitalEquipmentItem.UnitCost,
            EquipmentSummary = capitalEquipmentItem.EquipmentSummary,
        };

        JustificationPrioritization justificationPrioritization = new JustificationPrioritization()
        {
            DepartmentPriorityRanking = capitalEquipmentItem.DepartmentPriorityRanking,
            ExpectedOutcomes = capitalEquipmentItem.ExpectedOutcomes,
            PurposeOfExpenditure = capitalEquipmentItem.PurposeOfExpenditure,
            JustificationForReplacement = capitalEquipmentItem.JustificationForReplacement
        };

        JustificationMatrix justificationMatrix = new JustificationMatrix()
        {
            RequiredMandatedPriority = capitalEquipmentItem.RequiredMandatedPriority,
            SafetyPriority = capitalEquipmentItem.SafetyPriority,
            PaybackPeriodPriority = capitalEquipmentItem.PaybackPeriodPriority,
            SustainabilityPriority = capitalEquipmentItem.SustainabilityPriority,
            CostToOperatePriority = capitalEquipmentItem.CostToOperatePriority,
            RevenueGenerationPriority = capitalEquipmentItem.RevenueGenerationPriority,
            RequiredMandatedExplanation = capitalEquipmentItem.RequiredMandatedExplanation,
            SafetyExplanation = capitalEquipmentItem.SafetyExplanation,
            PaybackPeriodExplanation = capitalEquipmentItem.PaybackPeriodExplanation,
            SustainabilityExplanation = capitalEquipmentItem.SustainabilityExplanation,
            CostToOperateExplanation = capitalEquipmentItem.CostToOperateExplanation,
            RevenueGenerationExplanation = capitalEquipmentItem.RevenueGenerationExplanation
        };

        ExistingAssetInfo existingAssetInfo = new ExistingAssetInfo()
        {
            AssetBeingReplaced = capitalEquipmentItem.AssetBeingReplaced,
            ConditionOfAssetBeingReplaced = capitalEquipmentItem.ConditionOfAssetBeingReplaced,
            OdometerReadingHours = capitalEquipmentItem.OdometerReadingHours,
            StandardReplacementCycle = capitalEquipmentItem.StandardReplacementCycle,
            EstimatedLifeOfEquipment = capitalEquipmentItem.EstimatedLifeOfEquipment,
        };

        OperatingBudgetImpact operatingBudgetImpact = new OperatingBudgetImpact()
        {
            DepartmentResponsibleForOperatingCosts = capitalEquipmentItem.DepartmentResponsibleForOperatingCosts,
            AnnualOperatingCosts = capitalEquipmentItem.AnnualOperatingCosts,
            AnnualRevenueFromEquipment = capitalEquipmentItem.AnnualRevenueFromEquipment
        };

        ApprovalOversightInfo approvalOversightInfo = new ApprovalOversightInfo()
        {
            HasPurchaseBeenApprovedByOversight = !capitalEquipmentItem.HasPurchaseBeenApprovedByOversight,
            LegistarApprovalItemNumber = capitalEquipmentItem.LegistarApprovalItemNumber,
            ApprovingOversightBoard = capitalEquipmentItem.ApprovingOversightBoard,
            DateOfOversightApproval = capitalEquipmentItem.DateOfOversightApproval,
            PurchasingBuyerReview = capitalEquipmentItem.PurchasingBuyerReview,
            AdditionalNotes = capitalEquipmentItem.AdditionalNotes,
        };

        return new GetCapitalEquipmentResponse(
            capitalEquipmentItem.Id,
            capitalEquipmentItem.BudgetId,
            capitalEquipmentItem.RevisionTitle,
            capitalEquipmentItem.RequestId,
            capitalEquipmentItem.Title,
            generalInfo,
            equipmentInfo,
            justificationPrioritization,
            justificationMatrix,
            existingAssetInfo,
            operatingBudgetImpact,
            approvalOversightInfo
            );
    }
}
