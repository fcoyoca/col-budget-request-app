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

        var spec = new GetCapitalProjectGeneralInfoByIdsSpec(request.Ids);
        
        var projects = await repository.ListAsync(spec, cancellationToken);
        
        var targetProjects = projects.Where(x => request.Ids.Contains(x.Id)).ToList();

        foreach (var project in targetProjects)
        {
            project.GeneralInformation.RequestStatusId = request.StatusId.ToString();
        }
        
        await repository.UpdateRangeAsync(targetProjects, cancellationToken);

        return new UpdateStatusCapitalProjectResponse(request.Ids);
    }
}
