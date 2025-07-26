namespace budget_request_app.WebApi.LookupValue.Features.EquipmentDepartments.Get.v1;
public record GetEquipmentDepartmentResponse(
        Guid id,
        string budgetId,
        string subId,
        string title,
        string abbreviation,
        string color,
        string fundingCategory,
        Guid lookupValueId
    );
