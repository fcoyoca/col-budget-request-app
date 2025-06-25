using FSH.Framework.Core.Persistence;
using budget_request_app.WebApi.ProjectFundingSource.Domain;
using budget_request_app.WebApi.ProjectFundingSource.Exceptions;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.ProjectFundingSource.Features.Update.v1;

public sealed class UpdateProjectFundingSourceHandler(
    ILogger<UpdateProjectFundingSourceHandler> logger,
    [FromKeyedServices("ProjectFundingSources")] IRepository<ProjectFundingSourceItem> repository)
    : IRequestHandler<UpdateProjectFundingSourceCommand, UpdateProjectFundingSourceResponse>
{
    public async Task<UpdateProjectFundingSourceResponse> Handle(UpdateProjectFundingSourceCommand request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);

        var projectFundingSource = await repository.GetByIdAsync(request.Id, cancellationToken);
        _ = projectFundingSource ?? throw new ProjectFundingSourceItemNotFoundException(request.Id);

        // Update properties
        projectFundingSource.SubId = request.SubId;
        projectFundingSource.Source = request.Source;
        projectFundingSource.SubSource = request.SubSource;
        projectFundingSource.SubSubSource = request.SubSubSource;
        projectFundingSource.DisplayName = request.DisplayName;
        projectFundingSource.DisplayTitle = request.DisplayTitle;
        projectFundingSource.DisplaySubTitle = request.DisplaySubTitle;
        projectFundingSource.ChartDisplayName = request.ChartDisplayName;
        projectFundingSource.IsCityFunded = request.IsCityFunded;
        projectFundingSource.IsNewBorrowing = request.IsNewBorrowing;
        projectFundingSource.IsGrantFunding = request.IsGrantFunding;
        projectFundingSource.IsOutsideFunding = request.IsOutsideFunding;
        projectFundingSource.IsTifIncrementFunding = request.IsTifIncrementFunding;

        await repository.UpdateAsync(projectFundingSource, cancellationToken);

        logger.LogInformation("ProjectFundingSource item updated: {ProjectFundingSourceItemId}", projectFundingSource.Id);

        return new UpdateProjectFundingSourceResponse(projectFundingSource.Id);
    }
}
