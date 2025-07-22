using System.ComponentModel;
using budget_request_app.WebApi.ProjectBudgetIntroSectionOutlineItem.Features.Create.v1;
using MediatR;

namespace budget_request_app.WebApi.ProjectBudgetIntroSectionOutlineItem.Features.Create.v1;
public record CreateProjectBudgetIntroSectionOutlineItemCommand(
        string BudgetId,
        string SectionTitle,
        int SortOrder,
        int PageNumberOffset,
        Guid LookupValueId
    ) : IRequest<CreateProjectBudgetIntroSectionOutlineItemResponse>;
