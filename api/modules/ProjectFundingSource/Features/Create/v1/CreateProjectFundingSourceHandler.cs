using FSH.Framework.Core.Persistence;
using budget_request_app.WebApi.ProjectFundingSource.Domain;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.ProjectFundingSource.Features.Create.v1;
public sealed class CreateProjectFundingSourceHandler(
    ILogger<CreateProjectFundingSourceHandler> logger,
    [FromKeyedServices("ProjectFundingSources")] IRepository<ProjectFundingSourceItem> repository)
    : IRequestHandler<CreateProjectFundingSourceCommand, CreateProjectFundingSourceResponse>
{
    public async Task<CreateProjectFundingSourceResponse> Handle(CreateProjectFundingSourceCommand request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        var item = ProjectFundingSourceItem.Create(
            request.SubId,
            request.SubSubId,
            request.Source,
            request.SubSource,
            request.SubSubSource,
            request.DisplayName,
            request.DisplayTitle,
            request.DisplaySubTitle,
            request.ChartDisplayName,
            request.IsCityFunded,
            request.IsNewBorrowing,
            request.BudgetId,
            request.IsGrantFunding,
            request.IsOutsideFunding,
            request.IsTifIncrementFunding,
            request.LookupValueId
        );
        
        await repository.AddAsync(item, cancellationToken).ConfigureAwait(false);
        await repository.SaveChangesAsync(cancellationToken).ConfigureAwait(false);
        logger.LogInformation("ProjectFundingSource item created {ProjectFundingSourceItemId}", item.Id);
        return new CreateProjectFundingSourceResponse(item.Id);
    }
}
