using FSH.Framework.Core.Persistence;
using budget_request_app.WebApi.EquipmentFundingSource.Domain;
using budget_request_app.WebApi.EquipmentFundingSource.Exceptions;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.EquipmentFundingSource.Features.Update.v1;

public sealed class UpdateEquipmentFundingSourceHandler(
    ILogger<UpdateEquipmentFundingSourceHandler> logger,
    [FromKeyedServices("EquipmentFundingSources")] IRepository<EquipmentFundingSourceItem> repository)
    : IRequestHandler<UpdateEquipmentFundingSourceCommand, UpdateEquipmentFundingSourceResponse>
{
    public async Task<UpdateEquipmentFundingSourceResponse> Handle(UpdateEquipmentFundingSourceCommand request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);

        var equipmentFundingSource = await repository.GetByIdAsync(request.Id, cancellationToken);
        _ = equipmentFundingSource ?? throw new EquipmentFundingSourceItemNotFoundException(request.Id);

        // Update properties
        equipmentFundingSource.SubId = request.SubId;
        equipmentFundingSource.SpecialCode = request.SpecialCode;
        equipmentFundingSource.BudgetId = request.BudgetId;
        equipmentFundingSource.Title = request.Title;
        equipmentFundingSource.Abbreviation = request.Abbreviation;
        equipmentFundingSource.Code = request.Code;
        equipmentFundingSource.IsNewBorrowing = request.IsNewBorrowing;
        equipmentFundingSource.FundingSource = request.FundingSource;
        equipmentFundingSource.FundingSubSource = request.FundingSubSource;

        await repository.UpdateAsync(equipmentFundingSource, cancellationToken);

        logger.LogInformation("EquipmentFundingSource item updated: {EquipmentFundingSourceItemId}", equipmentFundingSource.Id);

        return new UpdateEquipmentFundingSourceResponse(equipmentFundingSource.Id);
    }
}
