using FSH.Framework.Core.Persistence;
using budget_request_app.WebApi.LookupCategory.Domain;
using budget_request_app.WebApi.LookupCategory.Exceptions;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.LookupCategory.Features.Delete.v1;
public sealed class DeleteLookupCategoryHandler(
    ILogger<DeleteLookupCategoryHandler> logger,
    [FromKeyedServices("lookupCategories")] IRepository<LookupCategoryItem> repository)
    : IRequestHandler<DeleteLookupCategoryCommand>
{
    public async Task Handle(DeleteLookupCategoryCommand request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        var LookupCategoryItem = await repository.GetByIdAsync(request.Id, cancellationToken);
        _ = LookupCategoryItem ?? throw new LookupCategoryItemNotFoundException(request.Id);
        await repository.DeleteAsync(LookupCategoryItem, cancellationToken);
        logger.LogInformation("LookupCategory with id : {LookupCategoryId} deleted", LookupCategoryItem.Id);
    }
}
