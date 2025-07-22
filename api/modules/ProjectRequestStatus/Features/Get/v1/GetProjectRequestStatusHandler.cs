using System;
using budget_request_app.WebApi.ProjectRequestStatus.Features.Get.v1;
using budget_request_app.WebApi.ProjectRequestStatus.Domain;
using budget_request_app.WebApi.ProjectRequestStatus.Exceptions;
using FSH.Framework.Core.Caching;
using FSH.Framework.Core.Persistence;
using MediatR;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.DependencyInjection;

namespace budget_request_app.WebApi.ProjectRequestStatus.Features.Get.v1;
public sealed class GetProjectRequestStatusHandler(
    [FromKeyedServices("ProjectRequestStatuses")] IReadRepository<ProjectRequestStatusItem> repository,
    ICacheService cache)
    : IRequestHandler<GetProjectRequestStatusRequest, GetProjectRequestStatusResponse>
{
    public async Task<GetProjectRequestStatusResponse> Handle(GetProjectRequestStatusRequest request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        //var item = await cache.GetOrSetAsync(
        //    $"ProjectRequestStatuses:{request.Id}",
        //    async () =>
        //    {
        //        var ProjectRequestStatusItem = await repository.GetByIdAsync(request.Id, cancellationToken);
        //        if (ProjectRequestStatusItem == null) throw new ProjectRequestStatusItemNotFoundException(request.Id);
        //        return new GetProjectRequestStatusResponse(
        //            ProjectRequestStatusItem.Id,
        //            ProjectRequestStatusItem.BudgetId,
        //            ProjectRequestStatusItem.SubId,
        //            ProjectRequestStatusItem.Title,
        //            ProjectRequestStatusItem.IsUnfundedStatus,
        //            ProjectRequestStatusItem.LookupValueId
        //        );
        //    },
        //    cancellationToken: cancellationToken);
        //return item!;

        var ProjectRequestStatusItem = await repository.GetByIdAsync(request.Id, cancellationToken);
        if (ProjectRequestStatusItem == null) throw new ProjectRequestStatusItemNotFoundException(request.Id);
        return new GetProjectRequestStatusResponse(
            ProjectRequestStatusItem.Id,
            ProjectRequestStatusItem.BudgetId,
            ProjectRequestStatusItem.SubId,
            ProjectRequestStatusItem.Title,
            ProjectRequestStatusItem.IsUnfundedStatus,
            ProjectRequestStatusItem.LookupValueId
        );
    }
}

