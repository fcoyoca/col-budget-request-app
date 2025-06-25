namespace budget_request_app.WebApi.ProjectFundingSource.Features.GetList.v1;
public record ProjectFundingSourceDto(
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
    Guid LookupValueId
    );
