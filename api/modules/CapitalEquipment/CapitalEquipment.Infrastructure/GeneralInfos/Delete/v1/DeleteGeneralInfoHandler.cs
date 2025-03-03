using FSH.Framework.Core.Persistence;
using budget_request_app.WebApi.CapitalEquipment.Domain;
using budget_request_app.WebApi.CapitalEquipment.Domain.Exceptions;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.CapitalEquipment.Infrastructure.GeneralInfos.Delete.v1;
public sealed class DeleteGeneralInfoHandler(
    ILogger<DeleteGeneralInfoHandler> logger,
    [FromKeyedServices("capitalEquipment:generalInfos")] IRepository<GeneralInfo> repository)
    : IRequestHandler<DeleteGeneralInfoCommand>
{
    public async Task Handle(DeleteGeneralInfoCommand request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        var generalInfo = await repository.GetByIdAsync(request.Id, cancellationToken);
        _ = generalInfo ?? throw new GeneralInfoNotFoundException(request.Id);
        await repository.DeleteAsync(generalInfo, cancellationToken);
        logger.LogInformation("generalinfo with id : {GeneralInfoId} deleted", generalInfo.Id);
    }
}
