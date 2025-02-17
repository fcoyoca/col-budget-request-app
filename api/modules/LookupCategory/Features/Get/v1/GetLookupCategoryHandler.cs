using FSH.Framework.Core.Caching;
using FSH.Framework.Core.Persistence;
using budget_request_app.WebApi.LookupCategory.Domain;
using budget_request_app.WebApi.LookupCategory.Exceptions;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace budget_request_app.WebApi.LookupCategory.Features.Get.v1;
public sealed class GetLookupCategoryHandler(
    [FromKeyedServices("lookupCategories")] IReadRepository<LookupCategoryItem> repository,
    ICacheService cache)
    : IRequestHandler<GetLookupCategoryRequest, GetLookupCategoryResponse>
{
    public async Task<GetLookupCategoryResponse> Handle(GetLookupCategoryRequest request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        var item = await cache.GetOrSetAsync(
            $"LookupCategory:{request.Id}",
            async () =>
            {
                var LookupCategoryItem = await repository.GetByIdAsync(request.Id, cancellationToken);
                if (LookupCategoryItem == null) throw new LookupCategoryItemNotFoundException(request.Id);
                return new GetLookupCategoryResponse(LookupCategoryItem.Id, LookupCategoryItem.Name!, LookupCategoryItem.Description!, LookupCategoryItem.ModuleId.GetValueOrDefault());
            },
            cancellationToken: cancellationToken);
        return item!;
    }
}
