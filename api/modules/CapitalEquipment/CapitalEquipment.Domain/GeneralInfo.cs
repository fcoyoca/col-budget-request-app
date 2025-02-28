using FSH.Framework.Core.Domain;
using FSH.Framework.Core.Domain.Contracts;
using budget_request_app.WebApi.CapitalEquipment.Domain.Events;

namespace budget_request_app.WebApi.CapitalEquipment.Domain;
public class GeneralInfo : AuditableEntity, IAggregateRoot
{
    public string RequestStatusId { get; private set; } = default!;
    public string RemarksPrintout { get; private set; } = default!;
    public string RequestingDepartmentIds { get; private set; } = default!;
    public string DepartmentHeadRequestorId { get; private set; } = default!;
    public string EquipmentName { get; private set; } = default!;
    public string EquipmentCategoryId { get; private set; } = default!;
    public bool IsFinal { get; private set; } = false;

    public static GeneralInfo Create(string requestStatusId, string remarksPrintout, string requestingDepartmentIds, string departmentHeadRequestorId, string equipmentName, string equipmentCategoryId, bool isFinal)
    {
        var GeneralInfo = new GeneralInfo();

        GeneralInfo.RequestStatusId = requestStatusId;
        GeneralInfo.RemarksPrintout = remarksPrintout;
        GeneralInfo.RequestingDepartmentIds = requestingDepartmentIds;
        GeneralInfo.DepartmentHeadRequestorId = departmentHeadRequestorId;
        GeneralInfo.EquipmentName = equipmentName;
        GeneralInfo.EquipmentCategoryId = equipmentCategoryId;
        GeneralInfo.IsFinal = isFinal;
        
        GeneralInfo.QueueDomainEvent(new GeneralInfoCreated() { GeneralInfo = GeneralInfo });

        return GeneralInfo;
    }

    public GeneralInfo Update(string? requestStatusId)
    {
        this.QueueDomainEvent(new GeneralInfoUpdated() { GeneralInfo = this });
        return this;
    }

    public static GeneralInfo Update(Guid id, string requestStatusId, string remarksPrintout, string requestingDepartmentIds, string departmentHeadRequestorId, string equipmentName, string equipmentCategoryId, bool isFinal)
    {
        var GeneralInfo = new GeneralInfo
        {
            Id = id,
            RequestStatusId = requestStatusId,
            RemarksPrintout = remarksPrintout,
            RequestingDepartmentIds = requestingDepartmentIds,
            DepartmentHeadRequestorId = departmentHeadRequestorId,
            EquipmentName = equipmentName,
            EquipmentCategoryId = equipmentCategoryId,
            IsFinal = isFinal
        };

        GeneralInfo.QueueDomainEvent(new GeneralInfoUpdated() { GeneralInfo = GeneralInfo });

        return GeneralInfo;
    }
}
