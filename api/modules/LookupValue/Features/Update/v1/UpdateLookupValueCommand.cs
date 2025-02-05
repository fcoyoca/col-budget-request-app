using MediatR;

namespace budget_request_app.WebApi.LookupValue.Features.Update.v1;
public sealed record UpdateLookupValueCommand(
    Guid Id,
    string? Name,
    Guid? LookupCategoryId = null): IRequest<UpdateLookupValueResponse>;



