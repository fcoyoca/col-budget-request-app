using System.ComponentModel;
using MediatR;

namespace budget_request_app.WebApi.CapitalEquipment.Application.GeneralInfos.Create.v1;

public sealed record CreateGeneralInfoCommand(
    string? RequestStatusId,
    string? RemarksPrintout,
    string? RequestingDepartmentIds,
    string? DepartmentHeadRequestorId,
    string? EquipmentName,
    string? EquipmentCategoryId,
    bool IsFinal
) : IRequest<CreateGeneralInfoResponse>;
