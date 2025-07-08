using System.ComponentModel;
using MediatR;

namespace budget_request_app.WebApi.EquipmentFundingSource.Features.Create.v1;
public record CreateEquipmentFundingSourceCommand(
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
    ) : IRequest<CreateEquipmentFundingSourceResponse>;



