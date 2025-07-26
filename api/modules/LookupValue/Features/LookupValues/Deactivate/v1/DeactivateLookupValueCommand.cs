using MediatR;

namespace budget_request_app.WebApi.LookupValue.Features.LookupValues.Deactivate.v1;
public sealed record DeactivateLookupValueCommand(
    Guid Id): IRequest<DeactivateLookupValueResponse>;



