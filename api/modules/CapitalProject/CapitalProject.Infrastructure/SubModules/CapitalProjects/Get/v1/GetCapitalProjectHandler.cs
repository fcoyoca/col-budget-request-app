using Azure.Core;
using Microsoft.Extensions.DependencyInjection;
using budget_request_app.WebApi.CapitalProject.Domain.Exceptions;
using FSH.Framework.Core.Persistence;
using FSH.Framework.Core.Caching;
using budget_request_app.WebApi.CapitalProject.Domain;
//using budget_request_app.WebApi.CapitalProject.Infrastructure.SubModules.CapitalProjects.Create.v1;
using budget_request_app.WebApi.LookupValue.Domain;
using MediatR;

namespace budget_request_app.WebApi.CapitalProject.Infrastructure.SubModules.CapitalProjects.Get.v1;
public sealed class GetCapitalProjectHandler(
    [FromKeyedServices("capitalProjects")] IReadRepository<CapitalProjectItem> repository,
    [FromKeyedServices("lookupValues")] IReadRepository<LookupValueItem> lookupRepository,
    [FromKeyedServices("capitalProjectsFundingYearItems")] IReadRepository<FundingYearItem> repositoryFundingYearItem,
    ICacheService cache)
    : IRequestHandler<GetCapitalProjectRequest, GetCapitalProjectResponse>
{
    public async Task<GetCapitalProjectResponse> Handle(GetCapitalProjectRequest request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        // capitalProjectsFundingYearItems
        var lookupValues = await lookupRepository.ListAsync();

        var capitalProjectItem = await repository.FirstOrDefaultAsync(new GetCapitalProjectByIdSpec(request.Id));
        if (capitalProjectItem == null) throw new CapitalProjectNotFoundException(request.Id);
        var fundingYearItems = await repositoryFundingYearItem.ListAsync(cancellationToken);
        return CapitalProjectMapper.GetResponse(capitalProjectItem,lookupValues,fundingYearItems);
    }
}
