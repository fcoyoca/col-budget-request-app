using MediatR;

namespace budget_request_app.WebApi.LookupValue.Features.EquipmentDepartments.Update.v1;
public sealed record UpdateEquipmentDepartmentCommand(
        Guid Id,
        string BudgetId,
        string SubId,
        string Title,
        string Abbreviation,
        string Color,
        string FundingCategory,
        Guid LookupValueId) : IRequest<UpdateEquipmentDepartmentResponse>;
