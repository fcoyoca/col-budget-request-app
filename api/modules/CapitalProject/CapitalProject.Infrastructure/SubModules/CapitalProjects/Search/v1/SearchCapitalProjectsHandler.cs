using FSH.Framework.Core.Paging;
using FSH.Framework.Core.Persistence;
using budget_request_app.WebApi.CapitalProject.Infrastructure.SubModules.CapitalProjects.Get.v1;
using budget_request_app.WebApi.CapitalProject.Domain;
using budget_request_app.WebApi.FileService.Domain;
using budget_request_app.WebApi.LookupValue.Domain;
using Mapster;
using MediatR;
using Microsoft.Extensions.DependencyInjection;


namespace budget_request_app.WebApi.CapitalProject.Infrastructure.SubModules.CapitalProjects.Search.v1;
public sealed class SearchCapitalProjectsHandler(
    [FromKeyedServices("capitalProjects")] IReadRepository<CapitalProjectItem> repository,
    [FromKeyedServices("lookupValues")] IReadRepository<LookupValueItem> lookupRepository,
    [FromKeyedServices("capitalProjectsFundingYearItems")] IReadRepository<FundingYearItem> repositoryFundingYearItem,
    [FromKeyedServices("fileServices")] IReadRepository<FileServiceItem> fileRepository
    )
    : IRequestHandler<SearchCapitalProjectsCommand, PagedList<SearchCapitalProjectResponse>>
{
    public async Task<PagedList<SearchCapitalProjectResponse>> Handle(SearchCapitalProjectsCommand request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        
        var spec = new SearchCapitalProjectsSpec(request);

        var items = await repository.ListAsync(spec,cancellationToken).ConfigureAwait(false);
        
        var totalCount = await repository.CountAsync(spec, cancellationToken).ConfigureAwait(false);

        var lookupValues = await lookupRepository.ListAsync();
        
        var fundingYearItems = await repositoryFundingYearItem.ListAsync(cancellationToken);
        var files = await fileRepository.ListAsync();

        var mappedToGetResponse = items.Select(
            x => CapitalProjectMapper.GetResponse(x,lookupValues,fundingYearItems,files)
        );

        var mappedToAllListResponse = mappedToGetResponse.Adapt<List<SearchCapitalProjectResponse>>();
        
        var itemsMapped = mappedToAllListResponse.Select(
            x => new SearchCapitalProjectResponse(
                x.Id,
                x.GeneralInformation?.Title,
                MapToLookupNames(x.GeneralInformation.RequestingDepartmentIds, lookupValues),
                MapToLookupNames(x.GeneralInformation.DepartmentHeadRequestorId, lookupValues),
                lookupValues.FirstOrDefault(y => y.Id == Guid.Parse(x.GeneralInformation.RequestStatusId))?.Name,
                x.TimeJustificationApproval.JustificationPrioritization.DepartmentPriorityRanking.ToString(),
                
                x.BudgetId,
                x.RevisionTitle,
                x.GeneralInformation,
                x.TimeJustificationApproval,
                x.OperatingBudgetImpact,
                x.MinorProjectLocation,
                x.Financial,
                x.ProjectManagement,
                x.Attachments
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

