using FSH.Framework.Core.Persistence;
using budget_request_app.WebApi.LookupValue.Domain;
using budget_request_app.WebApi.LookupValue.Exceptions;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.LookupValue.Features.Update.v1;
public sealed class UpdateLookupValueHandler(
    ILogger<UpdateLookupValueHandler> logger,
    [FromKeyedServices("lookupValues")] IRepository<LookupValueItem> repository)
    : IRequestHandler<UpdateLookupValueCommand, UpdateLookupValueResponse>
{
    public async Task<UpdateLookupValueResponse> Handle(UpdateLookupValueCommand request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        var LookupValue = await repository.GetByIdAsync(request.Id, cancellationToken);
        _ = LookupValue ?? throw new LookupValueItemNotFoundException(request.Id);
        var updatedLookupValue = LookupValue.Update(request.Name);
        await repository.UpdateAsync(updatedLookupValue, cancellationToken);
        logger.LogInformation("LookupValue item updated {LookupValueItemId}", updatedLookupValue.Id);
        return new UpdateLookupValueResponse(updatedLookupValue.Id);
    }
}
