using FSH.Framework.Core.Persistence;
using budget_request_app.WebApi.CapitalEquipment.Domain;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.CapitalEquipment.Application.GeneralInfos.Create.v1;
public sealed class CreateGeneralInfoHandler(
    ILogger<CreateGeneralInfoHandler> logger,
    [FromKeyedServices("capitalEquipment:generalInfos")] IRepository<GeneralInfo> repository)
    : IRequestHandler<CreateGeneralInfoCommand, CreateGeneralInfoResponse>
{
    public async Task<CreateGeneralInfoResponse> Handle(CreateGeneralInfoCommand request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        var generalInfo = GeneralInfo.Create(request.RequestStatusId, request.RemarksPrintout, request.RequestingDepartmentIds, request.DepartmentHeadRequestorId, request.EquipmentName, request.EquipmentCategoryId, request.IsFinal);
        await repository.AddAsync(generalInfo, cancellationToken);
        logger.LogInformation("GeneralInfo created {GeneralInfoId}", generalInfo.Id);
        return new CreateGeneralInfoResponse(generalInfo.Id);
    }
}
