using FSH.Framework.Core.Persistence;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using budget_request_app.WebApi.LookupValue.Domain;

namespace budget_request_app.WebApi.LookupValue.Features.EquipmentDepartments.Create.v1;
public sealed class CreateEquipmentDepartmentHandler(
    ILogger<CreateEquipmentDepartmentHandler> logger,
    [FromKeyedServices("EquipmentDepartments")] IRepository<EquipmentDepartmentItem> repository)
    : IRequestHandler<CreateEquipmentDepartmentCommand, CreateEquipmentDepartmentResponse>
{
    public async Task<CreateEquipmentDepartmentResponse> Handle(CreateEquipmentDepartmentCommand request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        var item = EquipmentDepartmentItem.Create(
            request.BudgetId,
            request.SubId,
            request.Title,
            request.Abbreviation,
            request.Color,
            request.FundingCategory,
            request.LookupValueId
        );

        await repository.AddAsync(item, cancellationToken).ConfigureAwait(false);
        await repository.SaveChangesAsync(cancellationToken).ConfigureAwait(false);
        logger.LogInformation("EquipmentDepartment item created {EquipmentDepartmentItemId}", item.Id);
        return new CreateEquipmentDepartmentResponse(item.Id);
    }
}
