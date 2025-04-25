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
    : IRequestHandler<SearchCapitalProjectsCommand, PagedList<SearchCapitalProjectResponse>>
{
    public async Task<PagedList<SearchCapitalProjectResponse>> Handle(SearchCapitalProjectsCommand request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        
        var spec = new SearchCapitalProjectsSpec(request);

        var items = await repository.ListAsync(spec,cancellationToken).ConfigureAwait(false);
        
        var totalCount = await repository.CountAsync(spec, cancellationToken).ConfigureAwait(false);

        var lookupValues = await lookupRepository.ListAsync();
        
        var itemsMapped = items.Select(
            x => new SearchCapitalProjectResponse(
                x.Id,
                x.GeneralInformation?.Title,
                MapToLookupNames(x.GeneralInformation.RequestingDepartmentIds, lookupValues),
                MapToLookupNames(x.GeneralInformation.DepartmentHeadRequestorId, lookupValues),
                lookupValues.FirstOrDefault(y => y.Id == Guid.Parse(x.GeneralInformation.RequestStatusId))?.Name,
                x.JustificationPrioritization.DepartmentPriorityRanking.ToString()
                )
            );
        return new PagedList<SearchCapitalProjectResponse>(itemsMapped.ToList(), request!.PageNumber, request!.PageSize, totalCount);
    }

    private string MapToLookupNames(string delimitedIds, List<LookupValueItem> items)
    {
        if (string.IsNullOrWhiteSpace(delimitedIds))
        {
            return string.Empty;
        }

        var ids = delimitedIds
            .Trim()
            .Split(",")
            .Select(id => Guid.Parse(id.Trim()));

        items = items.Where(x => ids.Contains(x.Id)).ToList();
        
        var names = items.Select(x => x.Name).ToList();
        return string.Join(',', names);
    }
}

