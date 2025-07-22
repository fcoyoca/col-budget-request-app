using MediatR;

namespace budget_request_app.WebApi.ProjectExpenditureCategory.Features.Update.v1;
public sealed record UpdateProjectExpenditureCategoryCommand(
        Guid Id,
        string SubId,
        string Category,
        string SubCategory,
        string SubSubCategory,
        string ShortDisplayName,
        string BudgetId,
        Guid LookupValueId) : IRequest<UpdateProjectExpenditureCategoryResponse>;
