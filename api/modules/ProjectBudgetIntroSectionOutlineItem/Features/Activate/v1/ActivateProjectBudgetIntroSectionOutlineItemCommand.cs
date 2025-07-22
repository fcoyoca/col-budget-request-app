using budget_request_app.WebApi.ProjectBudgetIntroSectionOutlineItem.Features.Activate.v1;
using MediatR;

namespace budget_request_app.WebApi.ProjectBudgetIntroSectionOutlineItem.Features.Activate.v1;
public sealed record ActivateProjectBudgetIntroSectionOutlineItemCommand(
    Guid? Id): IRequest<ActivateProjectBudgetIntroSectionOutlineItemResponse>;
