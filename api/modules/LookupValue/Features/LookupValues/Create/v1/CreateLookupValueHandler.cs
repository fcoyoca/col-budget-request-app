using FSH.Framework.Core.Persistence;
using budget_request_app.WebApi.LookupValue.Domain;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.LookupValue.Features.LookupValues.Create.v1;
public sealed class CreateLookupValueHandler(
    ILogger<CreateLookupValueHandler> logger,
    [FromKeyedServices("lookupValues")] IRepository<LookupValueItem> repository)
    : IRequestHandler<CreateLookupValueCommand, CreateLookupValueResponse>
{
    public async Task<CreateLookupValueResponse> Handle(CreateLookupValueCommand request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        var item = LookupValueItem.Create(request.Name,request.LookupCategoryId);
        await repository.AddAsync(item, cancellationToken).ConfigureAwait(false);
        await repository.SaveChangesAsync(cancellationToken).ConfigureAwait(false);
        logger.LogInformation("LookupValue item created {LookupValueItemId}", item.Id);
        return new CreateLookupValueResponse(item.Id);
    }
}
