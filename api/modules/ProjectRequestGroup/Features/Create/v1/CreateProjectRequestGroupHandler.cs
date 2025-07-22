using FSH.Framework.Core.Persistence;
using budget_request_app.WebApi.ProjectRequestGroup.Domain;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.ProjectRequestGroup.Features.Create.v1;
public sealed class CreateProjectRequestGroupHandler(
    ILogger<CreateProjectRequestGroupHandler> logger,
    [FromKeyedServices("ProjectRequestGroups")] IRepository<ProjectRequestGroupItem> repository)
    : IRequestHandler<CreateProjectRequestGroupCommand, CreateProjectRequestGroupResponse>
{
    public async Task<CreateProjectRequestGroupResponse> Handle(CreateProjectRequestGroupCommand request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        var item = ProjectRequestGroupItem.Create(
            request.SubId,
            request.BudgetId,
            request.GroupTitle,
            request.GroupSortOrder,
            request.GroupAbbreviation,
            request.GroupColor,
            request.IncludeGroupFundingBreakdownGraph,
            request.IncludeGroupFundingBreakdownTable,
            request.IncludeGroupExpenditureBreakdownGraph,
            request.IncludeGroupExpenditureBreakdownTable,
            request.IsEquipmentGroup,
            request.LookupValueId
        );

        await repository.AddAsync(item, cancellationToken).ConfigureAwait(false);
        await repository.SaveChangesAsync(cancellationToken).ConfigureAwait(false);
        logger.LogInformation("ProjectRequestGroup item created {ProjectRequestGroupItemId}", item.Id);
        return new CreateProjectRequestGroupResponse(item.Id);
    }
}
