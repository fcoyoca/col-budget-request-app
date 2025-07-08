using FSH.Framework.Core.Persistence;
using budget_request_app.WebApi.EquipmentFundingSource.Domain;
using budget_request_app.WebApi.EquipmentFundingSource.Exceptions;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.EquipmentFundingSource.Features.Delete.v1;
public sealed class DeleteEquipmentFundingSourceHandler(
    ILogger<DeleteEquipmentFundingSourceHandler> logger,
    [FromKeyedServices("EquipmentFundingSources")] IRepository<EquipmentFundingSourceItem> repository)
    : IRequestHandler<DeleteEquipmentFundingSourceCommand>
{
    public async Task Handle(DeleteEquipmentFundingSourceCommand request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        var EquipmentFundingSourceItem = await repository.GetByIdAsync(request.Id, cancellationToken);
        _ = EquipmentFundingSourceItem ?? throw new EquipmentFundingSourceItemNotFoundException(request.Id);
        await repository.DeleteAsync(EquipmentFundingSourceItem, cancellationToken);
        logger.LogInformation("EquipmentFundingSource with id : {ProjectFundingSourceId} deleted", EquipmentFundingSourceItem.Id);
    }
}
