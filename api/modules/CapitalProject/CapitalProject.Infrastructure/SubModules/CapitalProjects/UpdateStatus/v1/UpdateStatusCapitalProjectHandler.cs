using System.Runtime.InteropServices.JavaScript;
using budget_request_app.WebApi.CapitalProject.Domain;
using budget_request_app.WebApi.CapitalProject.Domain.Exceptions;
using budget_request_app.WebApi.CapitalProject.Infrastructure.SubModules.CapitalProjects.Create.v1;
using budget_request_app.WebApi.CapitalProject.Infrastructure.SubModules.CapitalProjects.Get.v1;
using FSH.Framework.Core.Persistence;
using Mapster;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.CapitalProject.Infrastructure.SubModules.CapitalProjects.UpdateStatus.v1;
public sealed class UpdateStatusCapitalProjectHandler(
    ILogger<UpdateStatusCapitalProjectHandler> logger,
    [FromKeyedServices("capitalProjects")] IRepository<CapitalProjectItem> repository)
    : IRequestHandler<UpdateStatusCapitalProjectCommand, UpdateStatusCapitalProjectResponse>
{
    public async Task<UpdateStatusCapitalProjectResponse> Handle(UpdateStatusCapitalProjectCommand request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);

        var equipments = await repository.ListAsync();
        
        var targetEquipments = equipments.Where(x => request.Ids.Contains(x.Id)).ToList();

        foreach (var equipment in targetEquipments)
        {
            equipment.GeneralInformation.RequestStatusId = request.StatusId.ToString();
        }
        
        await repository.UpdateRangeAsync(targetEquipments, cancellationToken);

        return new UpdateStatusCapitalProjectResponse(request.Ids);
    }
}
