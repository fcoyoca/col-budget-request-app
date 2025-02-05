using MediatR;

namespace budget_request_app.WebApi.LookupCategory.Features.Delete.v1;
public sealed record DeleteLookupCategoryCommand(
    Guid Id) : IRequest;



