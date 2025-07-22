using FSH.Framework.Core.Persistence;
using budget_request_app.WebApi.ProjectRequestGroup.Domain;
using budget_request_app.WebApi.ProjectRequestGroup.Exceptions;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.ProjectRequestGroup.Features.Update.v1;

public sealed class UpdateProjectRequestGroupHandler(
    ILogger<UpdateProjectRequestGroupHandler> logger,
    [FromKeyedServices("ProjectRequestGroups")] IRepository<ProjectRequestGroupItem> repository)
    : IRequestHandler<UpdateProjectRequestGroupCommand, UpdateProjectRequestGroupResponse>
{
    public async Task<UpdateProjectRequestGroupResponse> Handle(UpdateProjectRequestGroupCommand request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);

        var projectRequestGroup = await repository.GetByIdAsync(request.Id, cancellationToken);
        _ = projectRequestGroup ?? throw new ProjectRequestGroupItemNotFoundException(request.Id);

        // Update properties
        projectRequestGroup.SubId = request.SubId;
        projectRequestGroup.BudgetId = request.BudgetId;
        projectRequestGroup.GroupTitle = request.GroupTitle;
        projectRequestGroup.GroupSortOrder = request.GroupSortOrder;
        projectRequestGroup.GroupAbbreviation = request.GroupAbbreviation;
        projectRequestGroup.GroupColor = request.GroupColor;
        projectRequestGroup.IncludeGroupFundingBreakdownGraph = request.IncludeGroupFundingBreakdownGraph;
        projectRequestGroup.IncludeGroupFundingBreakdownTable = request.IncludeGroupFundingBreakdownTable;
        projectRequestGroup.IncludeGroupExpenditureBreakdownGraph = request.IncludeGroupExpenditureBreakdownGraph;
        projectRequestGroup.IncludeGroupExpenditureBreakdownTable = request.IncludeGroupExpenditureBreakdownTable;
        projectRequestGroup.IsEquipmentGroup = request.IsEquipmentGroup;
        await repository.UpdateAsync(projectRequestGroup, cancellationToken);

        logger.LogInformation("ProjectRequestGroup item updated: {ProjectRequestGroupItemId}", projectRequestGroup.Id);

        return new UpdateProjectRequestGroupResponse(projectRequestGroup.Id);
    }
}
