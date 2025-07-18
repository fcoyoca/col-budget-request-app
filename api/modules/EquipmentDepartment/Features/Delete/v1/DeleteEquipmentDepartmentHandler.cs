using FSH.Framework.Core.Persistence;
using budget_request_app.WebApi.EquipmentDepartment.Domain;
using budget_request_app.WebApi.EquipmentDepartment.Exceptions;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.EquipmentDepartment.Features.Delete.v1;
public sealed class DeleteEquipmentDepartmentHandler(
    ILogger<DeleteEquipmentDepartmentHandler> logger,
    [FromKeyedServices("EquipmentDepartments")] IRepository<EquipmentDepartmentItem> repository)
    : IRequestHandler<DeleteEquipmentDepartmentCommand>
{
    public async Task Handle(DeleteEquipmentDepartmentCommand request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        var EquipmentDepartmentItem = await repository.GetByIdAsync(request.Id, cancellationToken);
        _ = EquipmentDepartmentItem ?? throw new EquipmentDepartmentItemNotFoundException(request.Id);
        await repository.DeleteAsync(EquipmentDepartmentItem, cancellationToken);
        logger.LogInformation("EquipmentDepartment with id : {EquipmentDepartmentId} deleted", EquipmentDepartmentItem.Id);
    }
}
