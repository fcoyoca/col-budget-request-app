using MediatR;

namespace budget_request_app.WebApi.LookupValue.Features.LookupValues.Activate.v1;
public sealed record ActivateLookupValueCommand(
    Guid? Id): IRequest<ActivateLookupValueResponse>;



