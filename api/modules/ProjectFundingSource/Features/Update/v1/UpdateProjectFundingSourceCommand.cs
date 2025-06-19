using MediatR;

namespace budget_request_app.WebApi.ProjectFundingSource.Features.Update.v1;
public sealed record UpdateProjectFundingSourceCommand(
    Guid Id,
    string SubId,
    string Source,
    string SubSource,
    string SubSubSource,
    string DisplayName,
    string DisplayTitle,
    string DisplaySubTitle,
    string ChartDisplayName,
    bool IsCityFunded,
    bool IsNewBorrowing,
    bool IsGrantFunding,
    bool IsOutsideFunding,
    bool IsTifIncrementFunding,
    Guid? LookupCategoryId = null): IRequest<UpdateProjectFundingSourceResponse>;



