using FSH.Framework.Core.Paging;
using FSH.Framework.Core.Persistence;
using budget_request_app.WebApi.CapitalProject.Infrastructure.SubModules.CapitalProjects.Get.v1;
using budget_request_app.WebApi.CapitalProject.Domain;
using budget_request_app.WebApi.LookupValue.Domain;
using MediatR;
using Microsoft.Extensions.DependencyInjection;


namespace budget_request_app.WebApi.CapitalProject.Infrastructure.SubModules.CapitalProjects.Search.v1;
public sealed class SearchCapitalProjectsHandler(
    [FromKeyedServices("capitalProjects")] IReadRepository<CapitalProjectItem> repository,
    [FromKeyedServices("lookupValues")] IReadRepository<LookupValueItem> lookupRepository)
    : IRequestHandler<SearchCapitalProjectsCommand, PagedList<GetCapitalProjectResponse>>
{
    public async Task<PagedList<GetCapitalProjectResponse>> Handle(SearchCapitalProjectsCommand request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);

        var spec = new SearchCapitalProjectSpecs(request);

        var items = await repository.ListAsync(spec,cancellationToken).ConfigureAwait(false);
        var totalCount = await repository.CountAsync(spec, cancellationToken).ConfigureAwait(false);

        var lookupValues = await lookupRepository.ListAsync();

        var itemsMapped = items.Select(
            x => CapitalProjectMapper.GetResponse(x, lookupValues, new List<FundingYearItem>())
            );
        return new PagedList<GetCapitalProjectResponse>(itemsMapped.ToList(), request!.PageNumber, request!.PageSize, totalCount);
    }
}

