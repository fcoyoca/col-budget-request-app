using System;
using budget_request_app.WebApi.ProjectBudgetIntroSectionOutlineItem.Features.Get.v1;
using budget_request_app.WebApi.ProjectBudgetIntroSectionOutlineItem.Domain;
using budget_request_app.WebApi.ProjectBudgetIntroSectionOutlineItem.Exceptions;
using FSH.Framework.Core.Caching;
using FSH.Framework.Core.Persistence;
using MediatR;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.DependencyInjection;

namespace budget_request_app.WebApi.ProjectBudgetIntroSectionOutlineItem.Features.Get.v1;
public sealed class GetProjectBudgetIntroSectionOutlineItemHandler(
    [FromKeyedServices("ProjectBudgetIntroSectionOutlineItems")] IReadRepository<ProjectBudgetIntroSectionOutlineItemItem> repository,
    ICacheService cache)
    : IRequestHandler<GetProjectBudgetIntroSectionOutlineItemRequest, GetProjectBudgetIntroSectionOutlineItemResponse>
{
    public async Task<GetProjectBudgetIntroSectionOutlineItemResponse> Handle(GetProjectBudgetIntroSectionOutlineItemRequest request, CancellationToken cancellationToken)
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

        var ProjectBudgetIntroSectionOutlineItem = await repository.GetByIdAsync(request.Id, cancellationToken);
        if (ProjectBudgetIntroSectionOutlineItem == null) throw new ProjectBudgetIntroSectionOutlineItemItemNotFoundException(request.Id);
        return new GetProjectBudgetIntroSectionOutlineItemResponse(
            ProjectBudgetIntroSectionOutlineItem.Id,
            ProjectBudgetIntroSectionOutlineItem.BudgetId,
            ProjectBudgetIntroSectionOutlineItem.SectionTitle,
            ProjectBudgetIntroSectionOutlineItem.SortOrder,
            ProjectBudgetIntroSectionOutlineItem.PageNumberOffset,
            ProjectBudgetIntroSectionOutlineItem.LookupValueId
        );
    }
}

