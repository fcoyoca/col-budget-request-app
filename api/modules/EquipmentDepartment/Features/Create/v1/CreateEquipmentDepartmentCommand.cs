using System.ComponentModel;
using MediatR;

namespace budget_request_app.WebApi.EquipmentDepartment.Features.Create.v1;
public record CreateEquipmentDepartmentCommand(
        string BudgetId,
        string SubId,
        string Title,
        string Abbreviation,
        string Color,
        string FundingCategory,
        Guid LookupValueId
    ) : IRequest<CreateEquipmentDepartmentResponse>;



