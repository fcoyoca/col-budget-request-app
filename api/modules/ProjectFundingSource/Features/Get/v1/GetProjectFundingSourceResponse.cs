namespace budget_request_app.WebApi.ProjectFundingSource.Features.Get.v1;
public record GetProjectFundingSourceResponse(
    Guid id,
    string subId,
    string source,
    string subSource,
    string subSubSource,
    string displayName,
    string displayTitle,
    string displaySubTitle,
    string chartDisplayName,
    bool isCityFunded,
    bool isNewBorrowing,
    string budgetId,
    bool isGrantFunding,
    bool isOutsideFunding,
    bool isTifIncrementFunding,
    Guid lookupValueId
    );
