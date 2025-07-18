using budget_request_app.WebApi.EquipmentFundingSource.Features.Activate.v1;
using budget_request_app.WebApi.EquipmentFundingSource.Domain;
using budget_request_app.WebApi.EquipmentFundingSource.Exceptions;
using FSH.Framework.Core.Persistence;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.EquipmentFundingSource.Features.Activate.v1;
public sealed class ActivateEquipmentFundingSourceHandler(
    ILogger<ActivateEquipmentFundingSourceHandler> logger,
    [FromKeyedServices("EquipmentFundingSources")] IRepository<EquipmentFundingSourceItem> repository)
    : IRequestHandler<ActivateEquipmentFundingSourceCommand, ActivateEquipmentFundingSourceResponse>
{
    public async Task<ActivateEquipmentFundingSourceResponse> Handle(ActivateEquipmentFundingSourceCommand request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        var EquipmentFundingSource = await repository.GetByIdAsync(request.Id, cancellationToken);
        _ = EquipmentFundingSource ?? throw new EquipmentFundingSourceItemNotFoundException(request.Id.Value);
        EquipmentFundingSource.IsActive = true;
        await repository.UpdateAsync(EquipmentFundingSource, cancellationToken);
        logger.LogInformation("EquipmentFundingSource item Activated {EquipmentFundingSourceItemId}", EquipmentFundingSource.Id);
        return new ActivateEquipmentFundingSourceResponse(EquipmentFundingSource.Id);
    }
}
