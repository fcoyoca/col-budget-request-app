using budget_request_app.WebApi.BudgetYear.Domain;
using FSH.Framework.Core.Persistence;
using budget_request_app.WebApi.CapitalEquipment.Domain;
using FSH.Framework.Core.Exceptions;
using Mapster;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using PastFunding = budget_request_app.WebApi.CapitalProject.Domain.PastFunding;
using FSH.Framework.Core.Storage.File;
using FSH.Framework.Core.Storage;
using FSH.Framework.Core.Storage.File.Features;
using Microsoft.AspNetCore.Components;

namespace budget_request_app.WebApi.CapitalEquipment.Infrastructure.SubModules.CapitalEquipments.Create.v1;
public sealed class CreateCapitalEquipmentHandler(
    IStorageService storageService,
    ILogger<CreateCapitalEquipmentHandler> logger,
    [FromKeyedServices("capitalEquipments")] IRepository<CapitalEquipmentItem> repository,
    [FromKeyedServices("budgetYears")] IRepository<BudgetYearItem> budgetYearRepository)
    : IRequestHandler<CreateCapitalEquipmentCommand, CreateCapitalEquipmentResponse>
{
    public async Task<CreateCapitalEquipmentResponse> Handle(CreateCapitalEquipmentCommand request, CancellationToken cancellationToken)
    {
        var budgetYears = await budgetYearRepository.ListAsync();

        if (budgetYears.Count == 0)
        {
            throw new NotFoundException("budget year not found");
        }
        
        ArgumentNullException.ThrowIfNull(request);
        
        var maxBudgetYear = budgetYears.Select(x => x.BudgetYear).Max();
        
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

        fundingItems = new List<FundingItem>();
        fundingItems.AddRange(borrowingFundings);
        fundingItems.AddRange(oueFundings);
        fundingItems.AddRange(grantFundings);
        fundingItems.AddRange(outsideFundings);
        fundingItems.AddRange(specialFundings);
        fundingItems.AddRange(otherFundings);
        
        var allEquipmentRequests = await repository.ListAsync();

        int requestId = 1;

        int requestNumber = 1;

        if (allEquipmentRequests.Any())
        {
            var currentYearRequests = allEquipmentRequests
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

        //var projectNumber = ( maxBudgetYear % 100 ) + (requestNumber % 1000).ToString("D3");

        if (request.ImageFile != null)
        {
            try
            {
                FileUploadCommand fileUploadCommand = new FileUploadCommand();
                fileUploadCommand.Data = request.ImageFile.ImageFile.Split(',')[1];
                fileUploadCommand.Name = request.ImageFile.ImageFileName + '_' + Guid.NewGuid();
                fileUploadCommand.Extension = request.ImageFile.ImageFileExt;

                var uploadedFile = await storageService.UploadAttachmentAsync(fileUploadCommand, FileType.Image, cancellationToken);
                request.ImageFile.ImageFilePath = uploadedFile.AbsoluteUri;
            }
            catch (Exception ex)
            {
                var message = ex.Message;
            }
        }


        var data = CapitalEquipmentItem.Create(
            requestNumber,
            request.ProjectNumber,
            maxBudgetYear.ToString() ?? string.Empty,
            request.RevisionTitle ?? string.Empty,
            requestId,
            request.Title ?? string.Empty,
            generalInfo.RequestStatusId ?? string.Empty,
            generalInfo.RemarksPrintout ?? string.Empty,
            generalInfo.RequestingDepartmentIds ?? string.Empty,
            generalInfo.DepartmentHeadRequestorId ?? string.Empty,
            generalInfo.EquipmentName,
            generalInfo.EquipmentCategoryId ?? string.Empty,
            equipmentInfo.IsNew,
            equipmentInfo.IsReplacement,
            equipmentInfo.IsLeasedVehicle,
            equipmentInfo.Quantity,
            equipmentInfo.UnitCost,
            equipmentInfo.EquipmentSummary ?? string.Empty,
            justificationPrioritization.DepartmentPriorityRanking,
            justificationPrioritization.ExpectedOutcomes ?? string.Empty,
            justificationPrioritization.PurposeOfExpenditure ?? string.Empty,
            justificationPrioritization.JustificationForReplacement ?? string.Empty,
            justificationMatrix.RequiredMandatedPriority ?? string.Empty,
            justificationMatrix.SafetyPriority ?? string.Empty,
            justificationMatrix.PaybackPeriodPriority ?? string.Empty,
            justificationMatrix.SustainabilityPriority ?? string.Empty,
            justificationMatrix.CostToOperatePriority ?? string.Empty,
            justificationMatrix.RevenueGenerationPriority ?? string.Empty,
            justificationMatrix.RequiredMandatedExplanation ?? string.Empty,
            justificationMatrix.SafetyExplanation ?? string.Empty,
            justificationMatrix.PaybackPeriodExplanation ?? string.Empty,
            justificationMatrix.SustainabilityExplanation ?? string.Empty,
            justificationMatrix.CostToOperateExplanation ?? string.Empty,
            justificationMatrix.RevenueGenerationExplanation ?? string.Empty,
            existingAssetInfo.AssetBeingReplaced ?? string.Empty,
            existingAssetInfo.ConditionOfAssetBeingReplaced ?? string.Empty,
            existingAssetInfo.OdometerReadingHours.ToString(),
            existingAssetInfo.StandardReplacementCycle ?? string.Empty,
            existingAssetInfo.EstimatedLifeOfEquipment,
            operatingBudgetImpact.DepartmentResponsibleForOperatingCosts ?? string.Empty,
            operatingBudgetImpact.AnnualOperatingCosts,
            operatingBudgetImpact.AnnualRevenueFromEquipment,
            approvalOversightInfo.HasPurchaseBeenApprovedByOversight,
            approvalOversightInfo.LegistarApprovalItemNumber ?? string.Empty,
            approvalOversightInfo.ApprovingOversightBoard.ToString(),
            approvalOversightInfo.DateOfOversightApproval,
            approvalOversightInfo.PurchasingBuyerReview,
            approvalOversightInfo.AdditionalNotes ?? string.Empty,
            fundingItems,
            //request.Funding.PastFundings.Adapt<List<CapitalEquipment.Domain.PastFunding>>(),
            request.FileIds ?? string.Empty,
            request.ImageFile?.ImageFilePath ?? string.Empty
            );
        
        await repository.AddAsync(data, cancellationToken);
        logger.LogInformation("CapitalEquipment created {CapitalEquipmentId}", data.Id);
        return new CreateCapitalEquipmentResponse(data.Id);
    }
}
