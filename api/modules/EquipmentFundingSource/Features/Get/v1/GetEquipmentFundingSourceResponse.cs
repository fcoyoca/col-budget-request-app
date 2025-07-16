namespace budget_request_app.WebApi.EquipmentFundingSource.Features.Get.v1;
public record GetEquipmentFundingSourceResponse(
        Guid id,
        string subId,
        string specialCode,
        string budgetId,
        string title,
        string abbreviation,
        string code,
        int sortOrder,
        bool isNewBorrowing,
        string fundingSource,
        string fundingSubSource,
        Guid lookupValueId
    );
