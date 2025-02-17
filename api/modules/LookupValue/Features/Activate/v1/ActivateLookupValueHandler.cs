using FSH.Framework.Core.Persistence;
using budget_request_app.WebApi.LookupValue.Domain;
using budget_request_app.WebApi.LookupValue.Exceptions;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.LookupValue.Features.Activate.v1;
public sealed class ActivateLookupValueHandler(
    ILogger<ActivateLookupValueHandler> logger,
    [FromKeyedServices("lookupValues")] IRepository<LookupValueItem> repository)
    : IRequestHandler<ActivateLookupValueCommand, ActivateLookupValueResponse>
{
    public async Task<ActivateLookupValueResponse> Handle(ActivateLookupValueCommand request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        var LookupValue = await repository.GetByIdAsync(request.Id, cancellationToken);
        _ = LookupValue ?? throw new LookupValueItemNotFoundException(request.Id.Value);
        LookupValue.IsActive = true;
        await repository.UpdateAsync(LookupValue, cancellationToken);
        logger.LogInformation("LookupValue item Activated {LookupValueItemId}", LookupValue.Id);
        return new ActivateLookupValueResponse(LookupValue.Id);
    }
}
