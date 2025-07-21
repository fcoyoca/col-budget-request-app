using FSH.Framework.Core.Persistence;
using budget_request_app.WebApi.ProjectRequestSubGroup.Domain;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.ProjectRequestSubGroup.Features.Create.v1;
public sealed class CreateProjectRequestSubGroupHandler(
    ILogger<CreateProjectRequestSubGroupHandler> logger,
    [FromKeyedServices("ProjectRequestSubGroups")] IRepository<ProjectRequestSubGroupItem> repository)
    : IRequestHandler<CreateProjectRequestSubGroupCommand, CreateProjectRequestSubGroupResponse>
{
    public async Task<CreateProjectRequestSubGroupResponse> Handle(CreateProjectRequestSubGroupCommand request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        var item = ProjectRequestSubGroupItem.Create(
            request.SubId,
            request.BudgetId,
            request.GroupId,
            request.SubGroupTitle,
            request.SubGroupSortOrder,
            request.SubGroupAbbreviation,
            request.SubGroupColor,
            request.IncludeSubGroupFundingBreakdownGraph,
            request.IncludeSubGroupFundingBreakdownTable,
            request.IncludeSubGroupExpenditureBreakdownGraph,
            request.IncludeSubGroupExpenditureBreakdownTable,
            request.LookupValueId
        );

        await repository.AddAsync(item, cancellationToken).ConfigureAwait(false);
        await repository.SaveChangesAsync(cancellationToken).ConfigureAwait(false);
        logger.LogInformation("ProjectRequestSubGroup item created {ProjectRequestSubGroupItemId}", item.Id);
        return new CreateProjectRequestSubGroupResponse(item.Id);
    }
}
