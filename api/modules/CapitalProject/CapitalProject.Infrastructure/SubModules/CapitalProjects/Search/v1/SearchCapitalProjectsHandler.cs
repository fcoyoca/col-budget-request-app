using budget_request_app.WebApi.CapitalProject.Domain;
using budget_request_app.WebApi.CapitalProject.Infrastructure.SubModules.CapitalProjects.Get.v1;
using budget_request_app.WebApi.FileService.Domain;
using budget_request_app.WebApi.LookupValue.Domain;
using FSH.Framework.Core.Identity.Users.Abstractions;
using FSH.Framework.Core.Paging;
using FSH.Framework.Core.Persistence;
using Mapster;
using MediatR;
using Microsoft.Extensions.DependencyInjection;


namespace budget_request_app.WebApi.CapitalProject.Infrastructure.SubModules.CapitalProjects.Search.v1;
public sealed class SearchCapitalProjectsHandler(
    [FromKeyedServices("capitalProjects")] IReadRepository<CapitalProjectItem> repository,
    [FromKeyedServices("lookupValues")] IReadRepository<LookupValueItem> lookupRepository,
    [FromKeyedServices("capitalProjectsFundingYearItems")] IReadRepository<FundingYearItem> repositoryFundingYearItem,
    [FromKeyedServices("fileServices")] IReadRepository<FileServiceItem> fileRepository,
    ICurrentUser userService
    )
    : IRequestHandler<SearchCapitalProjectsCommand, PagedList<SearchCapitalProjectResponse>>
{
    public async Task<PagedList<SearchCapitalProjectResponse>> Handle(SearchCapitalProjectsCommand request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);

        var currentUserId = userService.GetUserId();
        var spec = new SearchCapitalProjectsSpec(request, currentUserId);

        var items = await repository.ListAsync(spec, cancellationToken).ConfigureAwait(false);

        var totalCount = await repository.CountAsync(spec, cancellationToken).ConfigureAwait(false);

        var lookupValues = await lookupRepository.ListAsync(cancellationToken);

        var fundingYearItems = await repositoryFundingYearItem.ListAsync(cancellationToken);
        var files = await fileRepository.ListAsync(cancellationToken);

        var mappedToGetResponse = items.Select(
            x => CapitalProjectMapper.GetResponse(x, lookupValues, fundingYearItems, files)
        );

        var mappedToAllListResponse = mappedToGetResponse.Adapt<List<SearchCapitalProjectResponse>>();

        var itemsMapped = mappedToAllListResponse.Select(
            x => new SearchCapitalProjectResponse(
                x.Id,
                x.RequestNumber,
                x.ProjectNumber,
                x.MunisProjectNumber,
                x.GeneralInformation?.Title,
                CapitalProjectMapper.MapToLookupNames(x.GeneralInformation.RequestingDepartmentIds, lookupValues),
                CapitalProjectMapper.MapToLookupNames(x.GeneralInformation.DepartmentHeadRequestorId, lookupValues),
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
                x.Attachments,
                x.ImageFileUrl,
                x.IsDraft
                )
            );

        return new PagedList<SearchCapitalProjectResponse>(itemsMapped.ToList(), request!.PageNumber, request!.PageSize, totalCount);
    }
}

