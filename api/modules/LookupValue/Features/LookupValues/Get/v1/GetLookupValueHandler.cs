using FSH.Framework.Core.Caching;
using FSH.Framework.Core.Persistence;
using budget_request_app.WebApi.LookupValue.Domain;
using budget_request_app.WebApi.LookupValue.Exceptions;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace budget_request_app.WebApi.LookupValue.Features.LookupValues.Get.v1;
public sealed class GetLookupValueHandler(
    [FromKeyedServices("lookupValues")] IReadRepository<LookupValueItem> repository,
    ICacheService cache)
    : IRequestHandler<GetLookupValueRequest, GetLookupValueResponse>
{
    public async Task<GetLookupValueResponse> Handle(GetLookupValueRequest request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        var item = await cache.GetOrSetAsync(
            $"LookupValue:{request.Id}",
            async () =>
            {
                var LookupValueItem = await repository.GetByIdAsync(request.Id, cancellationToken);
                if (LookupValueItem == null) throw new LookupValueItemNotFoundException(request.Id);
                return new GetLookupValueResponse(LookupValueItem.Id, LookupValueItem.Name!, LookupValueItem.LookupCategoryId!, LookupValueItem.IsActive);
            },
            cancellationToken: cancellationToken);
        return item!;
    }
}
