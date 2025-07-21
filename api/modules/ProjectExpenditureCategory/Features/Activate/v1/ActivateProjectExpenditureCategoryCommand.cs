using MediatR;

namespace budget_request_app.WebApi.ProjectExpenditureCategory.Features.Activate.v1;
public sealed record ActivateProjectExpenditureCategoryCommand(
    Guid? Id): IRequest<ActivateProjectExpenditureCategoryResponse>;
