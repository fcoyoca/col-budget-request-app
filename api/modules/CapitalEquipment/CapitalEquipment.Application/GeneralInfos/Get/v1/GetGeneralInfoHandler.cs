using Microsoft.Extensions.DependencyInjection;
using budget_request_app.WebApi.CapitalEquipment.Domain.Exceptions;
using FSH.Framework.Core.Persistence;
using FSH.Framework.Core.Caching;
using budget_request_app.WebApi.CapitalEquipment.Domain;
using MediatR;

namespace budget_request_app.WebApi.CapitalEquipment.Application.GeneralInfos.Get.v1;
public sealed class GetGeneralInfoHandler(
    [FromKeyedServices("capitalEquipment:generalInfos")] IReadRepository<GeneralInfo> repository,
    ICacheService cache)
    : IRequestHandler<GetGeneralInfoRequest, GeneralInfoResponse>
{
    public async Task<GeneralInfoResponse> Handle(GetGeneralInfoRequest request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        var item = await cache.GetOrSetAsync(
            $"GeneralInfo:{request.Id}",
            async () =>
            {
                var spec = new GetGeneralInfoSpecs(request.Id);
                var GeneralInfoItem = await repository.FirstOrDefaultAsync(spec, cancellationToken);
                if (GeneralInfoItem == null) throw new GeneralInfoNotFoundException(request.Id);
                return GeneralInfoItem;
            },
            cancellationToken: cancellationToken);
        return item!;
    }
}
