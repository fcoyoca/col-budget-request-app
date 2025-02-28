using budget_request_app.WebApi.CapitalEquipment.Application.GeneralInfos.Get.v1;

namespace budget_request_app.WebApi.CapitalEquipment.Application.GeneralInfos.Get.v1;
public sealed record GeneralInfoResponse(Guid? Id, string? requestStatusId, string? remarksPrintout, string? requestingDepartmentIds, string? departmentHeadRequestorId, string? equipmentName, string? equipmentCategoryId, bool? isFinal);
