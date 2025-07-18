using budget_request_app.WebApi.EquipmentDepartment.Features.Activate.v1;
using budget_request_app.WebApi.EquipmentDepartment.Domain;
using budget_request_app.WebApi.EquipmentDepartment.Exceptions;
using FSH.Framework.Core.Persistence;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.EquipmentDepartment.Features.Activate.v1;
public sealed class ActivateEquipmentDepartmentHandler(
    ILogger<ActivateEquipmentDepartmentHandler> logger,
    [FromKeyedServices("EquipmentDepartments")] IRepository<EquipmentDepartmentItem> repository)
    : IRequestHandler<ActivateEquipmentDepartmentCommand, ActivateEquipmentDepartmentResponse>
{
    public async Task<ActivateEquipmentDepartmentResponse> Handle(ActivateEquipmentDepartmentCommand request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        var EquipmentDepartment = await repository.GetByIdAsync(request.Id, cancellationToken);
        _ = EquipmentDepartment ?? throw new EquipmentDepartmentItemNotFoundException(request.Id.Value);
        EquipmentDepartment.IsActive = true;
        await repository.UpdateAsync(EquipmentDepartment, cancellationToken);
        logger.LogInformation("EquipmentDepartment item Activated {EquipmentDepartmentItemId}", EquipmentDepartment.Id);
        return new ActivateEquipmentDepartmentResponse(EquipmentDepartment.Id);
    }
}
