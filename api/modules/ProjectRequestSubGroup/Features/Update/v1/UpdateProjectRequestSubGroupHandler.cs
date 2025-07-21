using FSH.Framework.Core.Persistence;
using budget_request_app.WebApi.ProjectRequestSubGroup.Domain;
using budget_request_app.WebApi.ProjectRequestSubGroup.Exceptions;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.ProjectRequestSubGroup.Features.Update.v1;

public sealed class UpdateProjectRequestSubGroupHandler(
    ILogger<UpdateProjectRequestSubGroupHandler> logger,
    [FromKeyedServices("ProjectRequestSubGroups")] IRepository<ProjectRequestSubGroupItem> repository)
    : IRequestHandler<UpdateProjectRequestSubGroupCommand, UpdateProjectRequestSubGroupResponse>
{
    public async Task<UpdateProjectRequestSubGroupResponse> Handle(UpdateProjectRequestSubGroupCommand request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);

        var projectRequestSubGroup = await repository.GetByIdAsync(request.Id, cancellationToken);
        _ = projectRequestSubGroup ?? throw new ProjectRequestSubGroupItemNotFoundException(request.Id);

        // Update properties
        projectRequestSubGroup.SubId = request.SubId;
        projectRequestSubGroup.BudgetId = request.BudgetId;
        projectRequestSubGroup.GroupId = request.GroupId;
        projectRequestSubGroup.SubGroupTitle = request.SubGroupTitle;
        projectRequestSubGroup.SubGroupSortOrder = request.SubGroupSortOrder;
        projectRequestSubGroup.SubGroupAbbreviation = request.SubGroupAbbreviation;
        projectRequestSubGroup.SubGroupColor = request.SubGroupColor;
        projectRequestSubGroup.IncludeSubGroupFundingBreakdownGraph = request.IncludeSubGroupFundingBreakdownGraph;
        projectRequestSubGroup.IncludeSubGroupFundingBreakdownTable = request.IncludeSubGroupFundingBreakdownTable;
        projectRequestSubGroup.IncludeSubGroupExpenditureBreakdownGraph = request.IncludeSubGroupExpenditureBreakdownGraph;
        projectRequestSubGroup.IncludeSubGroupExpenditureBreakdownTable = request.IncludeSubGroupExpenditureBreakdownTable;
        await repository.UpdateAsync(projectRequestSubGroup, cancellationToken);

        logger.LogInformation("ProjectRequestSubGroup item updated: {ProjectRequestSubGroupItemId}", projectRequestSubGroup.Id);

        return new UpdateProjectRequestSubGroupResponse(projectRequestSubGroup.Id);
    }
}
