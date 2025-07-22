using MediatR;

namespace budget_request_app.WebApi.ProjectBudgetIntroSectionOutlineItem.Features.Update.v1;
public sealed record UpdateProjectBudgetIntroSectionOutlineItemCommand(
        Guid Id,
        string BudgetId,
        string SectionTitle,
        int SortOrder,
        int PageNumberOffset,
        Guid LookupValueId) : IRequest<UpdateProjectBudgetIntroSectionOutlineItemResponse>;
