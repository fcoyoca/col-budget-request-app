using FSH.Framework.Core.Persistence;
using budget_request_app.WebApi.LookupCategory.Domain;
using budget_request_app.WebApi.LookupCategory.Exceptions;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.LookupCategory.Features.Update.v1;
public sealed class UpdateLookupCategoryHandler(
    ILogger<UpdateLookupCategoryHandler> logger,
    [FromKeyedServices("lookupCategories")] IRepository<LookupCategoryItem> repository)
    : IRequestHandler<UpdateLookupCategoryCommand, UpdateLookupCategoryResponse>
{
    public async Task<UpdateLookupCategoryResponse> Handle(UpdateLookupCategoryCommand request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        var LookupCategory = await repository.GetByIdAsync(request.Id, cancellationToken);
        _ = LookupCategory ?? throw new LookupCategoryItemNotFoundException(request.Id);
        var updatedLookupCategory = LookupCategory.Update(request.Name, request.Description);
        await repository.UpdateAsync(updatedLookupCategory, cancellationToken);
        logger.LogInformation("LookupCategory item updated {LookupCategoryItemId}", updatedLookupCategory.Id);
        return new UpdateLookupCategoryResponse(updatedLookupCategory.Id);
    }
}
