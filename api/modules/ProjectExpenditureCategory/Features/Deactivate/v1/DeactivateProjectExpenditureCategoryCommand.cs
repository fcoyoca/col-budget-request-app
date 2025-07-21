using budget_request_app.WebApi.ProjectExpenditureCategory.Features.Activate.v1;
using MediatR;

namespace budget_request_app.WebApi.ProjectExpenditureCategory.Features.Deactivate.v1;
public sealed record DeactivateProjectExpenditureCategoryCommand(
    Guid Id): IRequest<DeactivateProjectExpenditureCategoryResponse>;
