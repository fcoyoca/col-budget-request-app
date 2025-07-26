using budget_request_app.WebApi.LookupValue.Domain;
using budget_request_app.WebApi.LookupValue.Exceptions;
using FSH.Framework.Core.Persistence;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.LookupValue.Features.EquipmentDepartments.Delete.v1;
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
