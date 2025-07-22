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
        //        var ProjectRequestGroupItem = await repository.GetByIdAsync(request.Id, cancellationToken);
        //        if (ProjectRequestGroupItem == null) throw new ProjectRequestStatusItemNotFoundException(request.Id);
        //        return new GetProjectRequestStatusResponse(
        //            ProjectRequestGroupItem.Id,
        //            ProjectRequestGroupItem.BudgetId,
        //            ProjectRequestGroupItem.SubId,
        //            ProjectRequestGroupItem.Title,
        //            ProjectRequestGroupItem.IsUnfundedStatus,
        //            ProjectRequestGroupItem.LookupValueId
        //        );
        //    },
        //    cancellationToken: cancellationToken);
        //return item!;

        var ProjectRequestGroupItem = await repository.GetByIdAsync(request.Id, cancellationToken);
        if (ProjectRequestGroupItem == null) throw new ProjectRequestStatusItemNotFoundException(request.Id);
        return new GetProjectRequestStatusResponse(
            ProjectRequestGroupItem.Id,
            ProjectRequestGroupItem.BudgetId,
            ProjectRequestGroupItem.SubId,
            ProjectRequestGroupItem.Title,
            ProjectRequestGroupItem.IsUnfundedStatus,
            ProjectRequestGroupItem.LookupValueId
        );
    }
}

