using System;
using budget_request_app.WebApi.EquipmentFundingSource.Domain;
using budget_request_app.WebApi.EquipmentFundingSource.Exceptions;
using FSH.Framework.Core.Caching;
using FSH.Framework.Core.Persistence;
using MediatR;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.DependencyInjection;

namespace budget_request_app.WebApi.EquipmentFundingSource.Features.Get.v1;
public sealed class GetEquipmentFundingSourceHandler(
    [FromKeyedServices("EquipmentFundingSources")] IReadRepository<EquipmentFundingSourceItem> repository,
    ICacheService cache)
    : IRequestHandler<GetEquipmentFundingSourceRequest, GetEquipmentFundingSourceResponse>
{
    public async Task<GetEquipmentFundingSourceResponse> Handle(GetEquipmentFundingSourceRequest request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        //var item = await cache.GetOrSetAsync(
        //    $"EquipmentFundingSource:{request.Id}",
        //    async () =>
        //    {
        //        var EquipmentFundingSourceItem = await repository.GetByIdAsync(request.Id, cancellationToken);
        //        if (EquipmentFundingSourceItem == null) throw new EquipmentFundingSourceItemNotFoundException(request.Id);
        //        return new GetEquipmentFundingSourceResponse(
        //            EquipmentFundingSourceItem.Id,
        //            EquipmentFundingSourceItem.SubId,
        //            EquipmentFundingSourceItem.SpecialCode,
        //            EquipmentFundingSourceItem.BudgetId,
        //            EquipmentFundingSourceItem.Title,
        //            EquipmentFundingSourceItem.Abbreviation,
        //            EquipmentFundingSourceItem.Code,
        //            EquipmentFundingSourceItem.SortOrder,
        //            EquipmentFundingSourceItem.IsNewBorrowing,
        //            EquipmentFundingSourceItem.FundingSource,
        //            EquipmentFundingSourceItem.FundingSubSource,
        //            EquipmentFundingSourceItem.LookupValueId
        //            );
        //    },
        //    cancellationToken: cancellationToken);
        //return item!;

        var EquipmentFundingSourceItem = await repository.GetByIdAsync(request.Id, cancellationToken);
        if (EquipmentFundingSourceItem == null) throw new EquipmentFundingSourceItemNotFoundException(request.Id);
        return new GetEquipmentFundingSourceResponse(
            EquipmentFundingSourceItem.Id,
            EquipmentFundingSourceItem.SubId,
            EquipmentFundingSourceItem.SpecialCode,
            EquipmentFundingSourceItem.BudgetId,
            EquipmentFundingSourceItem.Title,
            EquipmentFundingSourceItem.Abbreviation,
            EquipmentFundingSourceItem.Code,
            EquipmentFundingSourceItem.SortOrder,
            EquipmentFundingSourceItem.IsNewBorrowing,
            EquipmentFundingSourceItem.FundingSource,
            EquipmentFundingSourceItem.FundingSubSource,
            EquipmentFundingSourceItem.LookupValueId
            );
    }
}

