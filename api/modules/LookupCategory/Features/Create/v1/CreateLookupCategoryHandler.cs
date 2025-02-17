using FSH.Framework.Core.Persistence;
using budget_request_app.WebApi.LookupCategory.Domain;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace budget_request_app.WebApi.LookupCategory.Features.Create.v1;
public sealed class CreateLookupCategoryHandler(
    ILogger<CreateLookupCategoryHandler> logger,
    [FromKeyedServices("lookupCategories")] IRepository<LookupCategoryItem> repository)
    : IRequestHandler<CreateLookupCategoryCommand, CreateLookupCategoryResponse>
{
    public async Task<CreateLookupCategoryResponse> Handle(CreateLookupCategoryCommand request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        var item = LookupCategoryItem.Create(request.Name, request.Description, request.ModuleId);
        await repository.AddAsync(item, cancellationToken).ConfigureAwait(false);
        await repository.SaveChangesAsync(cancellationToken).ConfigureAwait(false);
        logger.LogInformation("LookupCategory item created {LookupCategoryItemId}", item.Id);
        return new CreateLookupCategoryResponse(item.Id);
    }
}
