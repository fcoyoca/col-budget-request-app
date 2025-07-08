namespace budget_request_app.WebApi.EquipmentFundingSource.Features.GetList.v1;
public record EquipmentFundingSourceDto(
    Guid Id,
    string SubId,
    string SpecialCode,
    string BudgetId,
    string Title,
    string Abbreviation,
    string Code,
    int SortOrder,
    bool IsNewBorrowing,
    string FundingSource,
    string FundingSubSource,
    Guid LookupValueId
    );
