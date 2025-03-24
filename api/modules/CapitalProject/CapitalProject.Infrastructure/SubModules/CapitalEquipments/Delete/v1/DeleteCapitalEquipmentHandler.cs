using budget_request_app.WebApi.CapitalEquipment.Domain;
using budget_request_app.WebApi.CapitalEquipment.Domain.Exceptions;
using budget_request_app.WebApi.CapitalEquipment.Infrastructure.SubModules.CapitalEquipments.Delete.v1;
using FSH.Framework.Core.Persistence;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.Catalog.Application.CapitalEquipments.Delete.v1;
public sealed class DeleteCapitalEquipmentHandler(
    ILogger<DeleteCapitalEquipmentHandler> logger,
    [FromKeyedServices("capitalEquipments")] IRepository<CapitalEquipmentItem> repository)
    : IRequestHandler<DeleteCapitalEquipmentCommand>
{
    public async Task Handle(DeleteCapitalEquipmentCommand request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        var capitalEquipment = await repository.GetByIdAsync(request.Id, cancellationToken);
        _ = capitalEquipment ?? throw new CapitalEquipmentNotFoundException(request.Id);
        await repository.DeleteAsync(capitalEquipment, cancellationToken);
        logger.LogInformation("capitalEquipment with id : {CapitalEquipmentId} deleted", capitalEquipment.Id);
    }
}
