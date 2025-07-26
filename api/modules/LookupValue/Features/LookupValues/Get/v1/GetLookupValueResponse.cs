namespace budget_request_app.WebApi.LookupValue.Features.LookupValues.Get.v1;
public record GetLookupValueResponse(Guid? Id, string? Name, Guid? LookupCategoryId, bool? IsActive);
