using MediatR;

namespace budget_request_app.WebApi.LookupValue.Features.LookupValues.Delete.v1;
public sealed record DeleteLookupValueCommand(
    Guid Id) : IRequest;



