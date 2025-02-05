using FSH.Framework.Core.Persistence;
using budget_request_app.WebApi.LookupValue.Domain;
using budget_request_app.WebApi.LookupValue.Exceptions;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.LookupValue.Features.Delete.v1;
public sealed class DeleteLookupValueHandler(
    ILogger<DeleteLookupValueHandler> logger,
    [FromKeyedServices("lookupValues")] IRepository<LookupValueItem> repository)
    : IRequestHandler<DeleteLookupValueCommand>
{
    public async Task Handle(DeleteLookupValueCommand request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        var LookupValueItem = await repository.GetByIdAsync(request.Id, cancellationToken);
        _ = LookupValueItem ?? throw new LookupValueItemNotFoundException(request.Id);
        await repository.DeleteAsync(LookupValueItem, cancellationToken);
        logger.LogInformation("LookupValue with id : {LookupValueId} deleted", LookupValueItem.Id);
    }
}
