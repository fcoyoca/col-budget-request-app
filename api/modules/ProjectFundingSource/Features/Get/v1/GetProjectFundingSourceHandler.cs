using FSH.Framework.Core.Caching;
using FSH.Framework.Core.Persistence;
using budget_request_app.WebApi.ProjectFundingSource.Domain;
using budget_request_app.WebApi.ProjectFundingSource.Exceptions;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace budget_request_app.WebApi.ProjectFundingSource.Features.Get.v1;
public sealed class GetProjectFundingSourceHandler(
    [FromKeyedServices("ProjectFundingSources")] IReadRepository<ProjectFundingSourceItem> repository,
    ICacheService cache)
    : IRequestHandler<GetProjectFundingSourceRequest, GetProjectFundingSourceResponse>
{
    public async Task<GetProjectFundingSourceResponse> Handle(GetProjectFundingSourceRequest request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        //var item = await cache.GetOrSetAsync(
        //    $"ProjectFundingSource:{request.Id}",
        //    async () =>
        //    {
        //        var ProjectFundingSourceItem = await repository.GetByIdAsync(request.Id, cancellationToken);
        //        if (ProjectFundingSourceItem == null) throw new ProjectFundingSourceItemNotFoundException(request.Id);
        //        return new GetProjectFundingSourceResponse(
        //            ProjectFundingSourceItem.Id,
        //            ProjectFundingSourceItem.SubId,
        //            ProjectFundingSourceItem.Source,
        //            ProjectFundingSourceItem.SubSource,
        //            ProjectFundingSourceItem.SubSubSource,
        //            ProjectFundingSourceItem.DisplayName,
        //            ProjectFundingSourceItem.DisplayTitle,
        //            ProjectFundingSourceItem.DisplaySubTitle,
        //            ProjectFundingSourceItem.ChartDisplayName,
        //            ProjectFundingSourceItem.IsCityFunded,
        //            ProjectFundingSourceItem.IsNewBorrowing,
        //            ProjectFundingSourceItem.IsGrantFunding,
        //            ProjectFundingSourceItem.IsOutsideFunding,
        //            ProjectFundingSourceItem.IsTifIncrementFunding,
        //            ProjectFundingSourceItem.LookupValueId
        //            );
        //    },
        //    cancellationToken: cancellationToken);
        //return item!;

        var ProjectFundingSourceItem = await repository.GetByIdAsync(request.Id, cancellationToken);
        if (ProjectFundingSourceItem == null) throw new ProjectFundingSourceItemNotFoundException(request.Id);
        return new GetProjectFundingSourceResponse(
            ProjectFundingSourceItem.Id,
            ProjectFundingSourceItem.SubId,
            ProjectFundingSourceItem.Source,
            ProjectFundingSourceItem.SubSource,
            ProjectFundingSourceItem.SubSubSource,
            ProjectFundingSourceItem.DisplayName,
            ProjectFundingSourceItem.DisplayTitle,
            ProjectFundingSourceItem.DisplaySubTitle,
            ProjectFundingSourceItem.ChartDisplayName,
            ProjectFundingSourceItem.IsCityFunded,
            ProjectFundingSourceItem.IsNewBorrowing,
            ProjectFundingSourceItem.BudgetId,
            ProjectFundingSourceItem.IsGrantFunding,
            ProjectFundingSourceItem.IsOutsideFunding,
            ProjectFundingSourceItem.IsTifIncrementFunding,
            ProjectFundingSourceItem.LookupValueId
            );
    }
}
