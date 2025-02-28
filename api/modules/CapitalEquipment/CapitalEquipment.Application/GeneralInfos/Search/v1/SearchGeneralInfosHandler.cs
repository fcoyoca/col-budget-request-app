using FSH.Framework.Core.Paging;
using FSH.Framework.Core.Persistence;
using budget_request_app.WebApi.CapitalEquipment.Application.GeneralInfos.Get.v1;
using budget_request_app.WebApi.CapitalEquipment.Domain;
using MediatR;
using Microsoft.Extensions.DependencyInjection;


namespace budget_request_app.WebApi.CapitalEquipment.Application.GeneralInfos.Search.v1;
public sealed class SearchGeneralInfosHandler(
    [FromKeyedServices("capitalEquipment:generalInfos")] IReadRepository<GeneralInfo> repository)
    : IRequestHandler<SearchGeneralInfosCommand, PagedList<GeneralInfoResponse>>
{
    public async Task<PagedList<GeneralInfoResponse>> Handle(SearchGeneralInfosCommand request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);

        var spec = new SearchGeneralInfoSpecs(request);

        var items = await repository.ListAsync(spec, cancellationToken).ConfigureAwait(false);
        var totalCount = await repository.CountAsync(spec, cancellationToken).ConfigureAwait(false);

        return new PagedList<GeneralInfoResponse>(items, request!.PageNumber, request!.PageSize, totalCount);
    }
}

