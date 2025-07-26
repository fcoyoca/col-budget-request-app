namespace budget_request_app.WebApi.LookupValue.Features.LookupValues.GetList.v1;
public record LookupValueDto(Guid? Id, string Name, Guid? LookupCategoryId, string? LookupCategoryName, bool? IsActive);
