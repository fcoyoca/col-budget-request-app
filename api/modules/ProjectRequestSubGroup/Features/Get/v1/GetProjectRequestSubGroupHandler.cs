using System;
using budget_request_app.WebApi.ProjectRequestSubGroup.Domain;
using budget_request_app.WebApi.ProjectRequestSubGroup.Exceptions;
using FSH.Framework.Core.Caching;
using FSH.Framework.Core.Persistence;
using MediatR;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.DependencyInjection;

namespace budget_request_app.WebApi.ProjectRequestSubGroup.Features.Get.v1;
public sealed class GetProjectRequestSubGroupHandler(
    [FromKeyedServices("ProjectRequestSubGroups")] IReadRepository<ProjectRequestSubGroupItem> repository,
    ICacheService cache)
    : IRequestHandler<GetProjectRequestSubGroupRequest, GetProjectRequestSubGroupResponse>
{
    public async Task<GetProjectRequestSubGroupResponse> Handle(GetProjectRequestSubGroupRequest request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        var item = await cache.GetOrSetAsync(
            $"ProjectRequestSubGroups:{request.Id}",
            async () =>
            {
                var ProjectRequestSubGroupItem = await repository.GetByIdAsync(request.Id, cancellationToken);
                if (ProjectRequestSubGroupItem == null) throw new ProjectRequestSubGroupItemNotFoundException(request.Id);
                return new GetProjectRequestSubGroupResponse(
                    ProjectRequestSubGroupItem.Id,
                    ProjectRequestSubGroupItem.SubId,
                    ProjectRequestSubGroupItem.BudgetId,
                    ProjectRequestSubGroupItem.GroupId,
                    ProjectRequestSubGroupItem.SubGroupTitle,
                    ProjectRequestSubGroupItem.SubGroupSortOrder,
                    ProjectRequestSubGroupItem.SubGroupAbbreviation,
                    ProjectRequestSubGroupItem.SubGroupColor,
                    ProjectRequestSubGroupItem.IncludeSubGroupFundingBreakdownGraph,
                    ProjectRequestSubGroupItem.IncludeSubGroupFundingBreakdownTable,
                    ProjectRequestSubGroupItem.IncludeSubGroupExpenditureBreakdownGraph,
                    ProjectRequestSubGroupItem.IncludeSubGroupExpenditureBreakdownTable,
                    ProjectRequestSubGroupItem.LookupValueId
                );
            },
            cancellationToken: cancellationToken);
        return item!;
    }
}

