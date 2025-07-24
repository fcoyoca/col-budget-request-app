using MediatR;

namespace budget_request_app.WebApi.ProjectBudgetIntroSectionOutlineItem.Features.Delete.v1;
public sealed record DeleteProjectBudgetIntroSectionOutlineItemCommand(
    Guid Id) : IRequest;
