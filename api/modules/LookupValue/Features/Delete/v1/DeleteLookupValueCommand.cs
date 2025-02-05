using MediatR;

namespace budget_request_app.WebApi.LookupValue.Features.Delete.v1;
public sealed record DeleteLookupValueCommand(
    Guid Id) : IRequest;



