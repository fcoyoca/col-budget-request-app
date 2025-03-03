namespace budget_request_app.WebApi.CapitalEquipment.Application.GeneralInfos.Get.v1;
public sealed record GetGeneralInfoResponse(Guid? Id, string? RequestStatusId, string? RemarksPrintout, string? RequestingDepartmentIds, string? DepartmentHeadRequestorId, string? EquipmentName, string? EquipmentCategoryId, bool? IsFinal);
