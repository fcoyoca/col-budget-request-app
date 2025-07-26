using FSH.Framework.Core.Persistence;
using budget_request_app.WebApi.LookupValue.Domain;
using budget_request_app.WebApi.LookupValue.Exceptions;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.LookupValue.Features.LookupValues.Deactivate.v1;
public sealed class DeactivateLookupValueHandler(
    ILogger<DeactivateLookupValueHandler> logger,
    [FromKeyedServices("lookupValues")] IRepository<LookupValueItem> repository)
    : IRequestHandler<DeactivateLookupValueCommand, DeactivateLookupValueResponse>
{
    public async Task<DeactivateLookupValueResponse> Handle(DeactivateLookupValueCommand request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        var LookupValue = await repository.GetByIdAsync(request.Id, cancellationToken);
        _ = LookupValue ?? throw new LookupValueItemNotFoundException(request.Id);
        LookupValue.IsActive = false;
        await repository.UpdateAsync(LookupValue, cancellationToken);
        logger.LogInformation("LookupValue item Deactivate {LookupValueItemId}", LookupValue.Id);
        return new DeactivateLookupValueResponse(LookupValue.Id);
    }
}
