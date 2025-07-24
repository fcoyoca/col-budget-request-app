using MediatR;

namespace budget_request_app.WebApi.ProjectExpenditureCategory.Features.Delete.v1;
public sealed record DeleteProjectExpenditureCategoryCommand(
    Guid Id) : IRequest;
