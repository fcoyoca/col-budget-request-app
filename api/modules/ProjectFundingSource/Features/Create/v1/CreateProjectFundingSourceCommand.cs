using System.ComponentModel;
using MediatR;

namespace budget_request_app.WebApi.ProjectFundingSource.Features.Create.v1;
public record CreateProjectFundingSourceCommand(
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
    Guid LookupValueId
    ) : IRequest<CreateProjectFundingSourceResponse>;



