using MediatR;

namespace budget_request_app.WebApi.LookupCategory.Features.Update.v1;
public sealed record UpdateLookupCategoryCommand(
    Guid Id,
    string? Name,
    string? Description = null): IRequest<UpdateLookupCategoryResponse>;



