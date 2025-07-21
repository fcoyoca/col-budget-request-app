using System;
using budget_request_app.WebApi.ProjectRequestGroup.Domain;
using budget_request_app.WebApi.ProjectRequestGroup.Exceptions;
using FSH.Framework.Core.Caching;
using FSH.Framework.Core.Persistence;
using MediatR;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.DependencyInjection;

namespace budget_request_app.WebApi.ProjectRequestGroup.Features.Get.v1;
public sealed class GetProjectRequestGroupHandler(
    [FromKeyedServices("ProjectRequestGroups")] IReadRepository<ProjectRequestGroupItem> repository,
    ICacheService cache)
    : IRequestHandler<GetProjectRequestGroupRequest, GetProjectRequestGroupResponse>
{
    public async Task<GetProjectRequestGroupResponse> Handle(GetProjectRequestGroupRequest request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        var item = await cache.GetOrSetAsync(
            $"ProjectRequestGroup:{request.Id}",
            async () =>
            {
                var ProjectRequestGroupItem = await repository.GetByIdAsync(request.Id, cancellationToken);
                if (ProjectRequestGroupItem == null) throw new ProjectRequestGroupItemNotFoundException(request.Id);
                return new GetProjectRequestGroupResponse(
                    ProjectRequestGroupItem.Id,
                    ProjectRequestGroupItem.SubId,
                    ProjectRequestGroupItem.BudgetId,
                    ProjectRequestGroupItem.GroupTitle,
                    ProjectRequestGroupItem.GroupSortOrder,
                    ProjectRequestGroupItem.GroupAbbreviation,
                    ProjectRequestGroupItem.GroupColor,
                    ProjectRequestGroupItem.IncludeGroupFundingBreakdownGraph,
                    ProjectRequestGroupItem.IncludeGroupFundingBreakdownTable,
                    ProjectRequestGroupItem.IncludeGroupExpenditureBreakdownGraph,
                    ProjectRequestGroupItem.IncludeGroupExpenditureBreakdownTable,
                    ProjectRequestGroupItem.IsEquipmentGroup,
                    ProjectRequestGroupItem.LookupValueId
                );
            },
            cancellationToken: cancellationToken);
        return item!;
    }
}

