using budget_request_app.WebApi.LookupValue.Domain;
using budget_request_app.WebApi.LookupValue.Exceptions;
using FSH.Framework.Core.Persistence;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.LookupValue.Features.EquipmentDepartments.Update.v1;

public sealed class UpdateEquipmentDepartmentHandler(
    ILogger<UpdateEquipmentDepartmentHandler> logger,
    [FromKeyedServices("EquipmentDepartments")] IRepository<EquipmentDepartmentItem> repository)
    : IRequestHandler<UpdateEquipmentDepartmentCommand, UpdateEquipmentDepartmentResponse>
{
    public async Task<UpdateEquipmentDepartmentResponse> Handle(UpdateEquipmentDepartmentCommand request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);

        var equipmentDepartment = await repository.GetByIdAsync(request.Id, cancellationToken);
        _ = equipmentDepartment ?? throw new EquipmentDepartmentItemNotFoundException(request.Id);

        // Update properties
        equipmentDepartment.BudgetId = request.BudgetId;
        equipmentDepartment.SubId = request.SubId;
        equipmentDepartment.Title = request.Title;
        equipmentDepartment.Abbreviation = request.Abbreviation;
        equipmentDepartment.Color = request.Color;
        equipmentDepartment.FundingCategory = request.FundingCategory;

        await repository.UpdateAsync(equipmentDepartment, cancellationToken);

        logger.LogInformation("EquipmentDepartment item updated: {EquipmentDepartmentItemId}", equipmentDepartment.Id);

        return new UpdateEquipmentDepartmentResponse(equipmentDepartment.Id);
    }
}
