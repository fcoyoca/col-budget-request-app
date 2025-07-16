using MediatR;

namespace budget_request_app.WebApi.EquipmentFundingSource.Features.Update.v1;
public sealed record UpdateEquipmentFundingSourceCommand(
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
        Guid LookupValueId) : IRequest<UpdateEquipmentFundingSourceResponse>;



