using budget_request_app.WebApi.CapitalProject.Domain;
using budget_request_app.WebApi.CapitalProject.Domain.Exceptions;
using budget_request_app.WebApi.FileService.Domain;
//using budget_request_app.WebApi.CapitalProject.Infrastructure.SubModules.CapitalProjects.Create.v1;
using budget_request_app.WebApi.LookupValue.Domain;
using FSH.Framework.Core.Caching;
using FSH.Framework.Core.Persistence;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace budget_request_app.WebApi.CapitalProject.Infrastructure.SubModules.CapitalProjects.Get.v1;
public sealed class GetCapitalProjectHandler(
    [FromKeyedServices("capitalProjects")] IReadRepository<CapitalProjectItem> repository,
    [FromKeyedServices("lookupValues")] IReadRepository<LookupValueItem> lookupRepository,
    [FromKeyedServices("capitalProjectsFundingYearItems")] IReadRepository<FundingYearItem> repositoryFundingYearItem,
    [FromKeyedServices("fileServices")] IReadRepository<FileServiceItem> fileRepository,
    ICacheService cache)
    : IRequestHandler<GetCapitalProjectRequest, GetCapitalProjectResponse>
{
    public async Task<GetCapitalProjectResponse> Handle(GetCapitalProjectRequest request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        // capitalProjectsFundingYearItems
        var lookupValues = await lookupRepository.ListAsync(cancellationToken);

        var capitalProjectItem = await repository.FirstOrDefaultAsync(new GetCapitalProjectByIdSpec(request.Id), cancellationToken);
        //var capitalProjectItem = await repository.GetByIdAsync(request.Id);
        if (capitalProjectItem == null) throw new CapitalProjectNotFoundException(request.Id);
        var fundingYearItems = await repositoryFundingYearItem.ListAsync(cancellationToken);
        var files = await fileRepository.ListAsync(cancellationToken);
        return CapitalProjectMapper.GetResponse(capitalProjectItem, lookupValues, fundingYearItems, files);
    }
}
