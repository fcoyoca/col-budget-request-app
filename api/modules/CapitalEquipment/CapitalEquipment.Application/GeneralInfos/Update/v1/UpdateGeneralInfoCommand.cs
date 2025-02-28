using MediatR;

namespace budget_request_app.WebApi.CapitalEquipment.Application.GeneralInfos.Update.v1;
public sealed record UpdateGeneralInfoCommand(
    Guid Id,
    string? RequestStatusId,
    string? RemarksPrintout,
    string? RequestingDepartmentIds,
    string? DepartmentHeadRequestorId,
    string? EquipmentName,
    string? EquipmentCategoryId,
    bool IsFinal ) : IRequest<UpdateGeneralInfoResponse>;
