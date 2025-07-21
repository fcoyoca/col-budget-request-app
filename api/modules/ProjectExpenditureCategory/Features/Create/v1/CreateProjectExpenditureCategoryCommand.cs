using System.ComponentModel;
using MediatR;

namespace budget_request_app.WebApi.ProjectExpenditureCategory.Features.Create.v1;
public record CreateProjectExpenditureCategoryCommand(
        string SubId,
        string Category,
        string SubCategory,
        string SubSubCategory,
        string ShortDisplayName,
        string BudgetId,
        Guid LookupValueId
    ) : IRequest<CreateProjectExpenditureCategoryResponse>;
