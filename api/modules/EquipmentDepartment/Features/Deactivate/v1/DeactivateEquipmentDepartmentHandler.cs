using budget_request_app.WebApi.EquipmentDepartment.Domain;
using budget_request_app.WebApi.EquipmentDepartment.Exceptions;
using budget_request_app.WebApi.EquipmentDepartment.Features.Activate.v1;
using FSH.Framework.Core.Persistence;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.EquipmentDepartment.Features.Deactivate.v1;
public sealed class DeactivateEquipmentDepartmentHandler(
    ILogger<DeactivateEquipmentDepartmentHandler> logger,
    [FromKeyedServices("EquipmentDepartments")] IRepository<EquipmentDepartmentItem> repository)
    : IRequestHandler<DeactivateEquipmentDepartmentCommand, DeactivateEquipmentDepartmentResponse>
{
    public async Task<DeactivateEquipmentDepartmentResponse> Handle(DeactivateEquipmentDepartmentCommand request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        var EquipmentDepartment = await repository.GetByIdAsync(request.Id, cancellationToken);
        _ = EquipmentDepartment ?? throw new EquipmentDepartmentItemNotFoundException(request.Id);
        EquipmentDepartment.IsActive = false;
        await repository.UpdateAsync(EquipmentDepartment, cancellationToken);
        logger.LogInformation("EquipmentDepartment item Deactivate {EquipmentDepartmentItemId}", EquipmentDepartment.Id);
        return new DeactivateEquipmentDepartmentResponse(EquipmentDepartment.Id);
    }
}
