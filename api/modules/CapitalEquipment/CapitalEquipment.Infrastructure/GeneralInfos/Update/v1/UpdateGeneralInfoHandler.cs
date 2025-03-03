using FSH.Framework.Core.Persistence;
using budget_request_app.WebApi.CapitalEquipment.Domain;
using budget_request_app.WebApi.CapitalEquipment.Domain.Exceptions;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.CapitalEquipment.Application.GeneralInfos.Update.v1;
public sealed class UpdateGeneralInfoHandler(
    ILogger<UpdateGeneralInfoHandler> logger,
    [FromKeyedServices("capitalEquipment:generalInfos")] IRepository<GeneralInfo> repository)
    : IRequestHandler<UpdateGeneralInfoCommand, UpdateGeneralInfoResponse>
{
    public async Task<UpdateGeneralInfoResponse> Handle(UpdateGeneralInfoCommand request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        var GeneralInfo = await repository.GetByIdAsync(request.Id, cancellationToken);
        _ = GeneralInfo ?? throw new GeneralInfoNotFoundException(request.Id);
        var updatedGeneralInfo = GeneralInfo.Update(request.Id, request.RequestStatusId, request.RemarksPrintout, request.RequestingDepartmentIds, request.DepartmentHeadRequestorId, request.EquipmentName, request.EquipmentCategoryId, request.IsFinal);
        await repository.UpdateAsync(updatedGeneralInfo, cancellationToken);
        logger.LogInformation("GeneralInfo with id : {GeneralInfoId} updated.", GeneralInfo.Id);
        return new UpdateGeneralInfoResponse(GeneralInfo.Id);
    }
}
