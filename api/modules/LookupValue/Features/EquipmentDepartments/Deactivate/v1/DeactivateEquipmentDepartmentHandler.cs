using budget_request_app.WebApi.LookupValue.Domain;
using budget_request_app.WebApi.LookupValue.Exceptions;
using FSH.Framework.Core.Persistence;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.LookupValue.Features.EquipmentDepartments.Deactivate.v1;
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
