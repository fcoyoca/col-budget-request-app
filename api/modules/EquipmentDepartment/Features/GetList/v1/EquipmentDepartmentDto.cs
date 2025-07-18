namespace budget_request_app.WebApi.EquipmentDepartment.Features.GetList.v1;
public record EquipmentDepartmentDto(
    Guid Id,
    string budgetId,
    string subId,
    string title,
    string abbreviation,
    string color,
    string fundingCategory,
    Guid LookupValueId
    );
