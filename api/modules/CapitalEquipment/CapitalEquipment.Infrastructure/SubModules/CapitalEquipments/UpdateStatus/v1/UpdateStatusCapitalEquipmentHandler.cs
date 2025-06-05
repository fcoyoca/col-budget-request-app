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

namespace budget_request_app.WebApi.CapitalEquipment.Infrastructure.SubModules.CapitalEquipments.UpdateStatus.v1;
public sealed class UpdateStatusCapitalEquipmentHandler(
    ILogger<UpdateStatusCapitalEquipmentHandler> logger,
    [FromKeyedServices("capitalEquipments")] IRepository<CapitalEquipmentItem> repository)
    : IRequestHandler<UpdateStatusCapitalEquipmentCommand, UpdateStatusCapitalEquipmentResponse>
{
    public async Task<UpdateStatusCapitalEquipmentResponse> Handle(UpdateStatusCapitalEquipmentCommand request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);

        var equipments = await repository.ListAsync();
        
        var targetEquipments = equipments.Where(x => request.Ids.Contains(x.Id)).ToList();

        foreach (var equipment in targetEquipments)
        {
            equipment.RequestStatusId = request.StatusId.ToString();
        }
        
        await repository.UpdateRangeAsync(targetEquipments, cancellationToken);

        return new UpdateStatusCapitalEquipmentResponse(request.Ids);
    }
}
