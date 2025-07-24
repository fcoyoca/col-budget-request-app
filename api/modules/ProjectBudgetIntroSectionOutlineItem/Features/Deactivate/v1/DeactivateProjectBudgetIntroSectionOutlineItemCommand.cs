﻿using budget_request_app.WebApi.ProjectBudgetIntroSectionOutlineItem.Features.Activate.v1;
using budget_request_app.WebApi.ProjectBudgetIntroSectionOutlineItem.Features.Activate.v1;
using MediatR;

namespace budget_request_app.WebApi.ProjectBudgetIntroSectionOutlineItem.Features.Deactivate.v1;
public sealed record DeactivateProjectBudgetIntroSectionOutlineItemCommand(
    Guid Id): IRequest<DeactivateProjectBudgetIntroSectionOutlineItemResponse>;
