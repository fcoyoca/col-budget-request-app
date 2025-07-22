using System;
using budget_request_app.WebApi.EquipmentDepartment.Domain;
using budget_request_app.WebApi.EquipmentDepartment.Exceptions;
using FSH.Framework.Core.Caching;
using FSH.Framework.Core.Persistence;
using MediatR;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.DependencyInjection;

namespace budget_request_app.WebApi.EquipmentDepartment.Features.Get.v1;
public sealed class GetEquipmentDepartmentHandler(
    [FromKeyedServices("EquipmentDepartments")] IReadRepository<EquipmentDepartmentItem> repository,
    ICacheService cache)
    : IRequestHandler<GetEquipmentDepartmentRequest, GetEquipmentDepartmentResponse>
{
    public async Task<GetEquipmentDepartmentResponse> Handle(GetEquipmentDepartmentRequest request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        //var item = await cache.GetOrSetAsync(
        //    $"EquipmentDepartment:{request.Id}",
        //    async () =>
        //    {
        //        var EquipmentDepartmentItem = await repository.GetByIdAsync(request.Id, cancellationToken);
        //        if (EquipmentDepartmentItem == null) throw new EquipmentDepartmentItemNotFoundException(request.Id);
        //        return new GetEquipmentDepartmentResponse(
        //            EquipmentDepartmentItem.Id,
        //            EquipmentDepartmentItem.BudgetId,
        //            EquipmentDepartmentItem.SubId,
        //            EquipmentDepartmentItem.Title,
        //            EquipmentDepartmentItem.Abbreviation,
        //            EquipmentDepartmentItem.Color,
        //            EquipmentDepartmentItem.FundingCategory,
        //            EquipmentDepartmentItem.LookupValueId
        //            );
        //    },
        //    cancellationToken: cancellationToken);
        //return item!;

        var EquipmentDepartmentItem = await repository.GetByIdAsync(request.Id, cancellationToken);
        if (EquipmentDepartmentItem == null) throw new EquipmentDepartmentItemNotFoundException(request.Id);
        return new GetEquipmentDepartmentResponse(
            EquipmentDepartmentItem.Id,
            EquipmentDepartmentItem.BudgetId,
            EquipmentDepartmentItem.SubId,
            EquipmentDepartmentItem.Title,
            EquipmentDepartmentItem.Abbreviation,
            EquipmentDepartmentItem.Color,
            EquipmentDepartmentItem.FundingCategory,
            EquipmentDepartmentItem.LookupValueId
            );
    }
}

