using budget_request_app.WebApi.EquipmentFundingSource.Domain;
using budget_request_app.WebApi.EquipmentFundingSource.Exceptions;
using budget_request_app.WebApi.EquipmentFundingSource.Features.Activate.v1;
using FSH.Framework.Core.Persistence;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.EquipmentFundingSource.Features.Deactivate.v1;
public sealed class DeactivateEquipmentFundingSourceHandler(
    ILogger<DeactivateEquipmentFundingSourceHandler> logger,
    [FromKeyedServices("EquipmentFundingSources")] IRepository<EquipmentFundingSourceItem> repository)
    : IRequestHandler<DeactivateEquipmentFundingSourceCommand, DeactivateEquipmentFundingSourceResponse>
{
    public async Task<DeactivateEquipmentFundingSourceResponse> Handle(DeactivateEquipmentFundingSourceCommand request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        var EquipmentFundingSource = await repository.GetByIdAsync(request.Id, cancellationToken);
        _ = EquipmentFundingSource ?? throw new EquipmentFundingSourceItemNotFoundException(request.Id);
        EquipmentFundingSource.IsActive = false;
        await repository.UpdateAsync(EquipmentFundingSource, cancellationToken);
        logger.LogInformation("EquipmentFundingSource item Deactivate {ProjectFundingSourceItemId}", EquipmentFundingSource.Id);
        return new DeactivateEquipmentFundingSourceResponse(EquipmentFundingSource.Id);
    }
}
