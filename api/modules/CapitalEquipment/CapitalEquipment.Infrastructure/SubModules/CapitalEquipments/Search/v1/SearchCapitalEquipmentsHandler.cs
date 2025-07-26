using budget_request_app.Shared.Authorization;
using budget_request_app.WebApi.CapitalEquipment.Domain;
using budget_request_app.WebApi.CapitalEquipment.Infrastructure.SubModules.CapitalEquipments.Get.v1;
using budget_request_app.WebApi.FileService.Domain;
using budget_request_app.WebApi.LookupValue.Domain;
using FSH.Framework.Core.Identity.Users.Abstractions;
using FSH.Framework.Core.Paging;
using FSH.Framework.Core.Persistence;
using MediatR;
using Microsoft.Extensions.DependencyInjection;


namespace budget_request_app.WebApi.CapitalEquipment.Infrastructure.SubModules.CapitalEquipments.Search.v1;
public sealed class SearchCapitalEquipmentsHandler(
    [FromKeyedServices("capitalEquipments")] IReadRepository<CapitalEquipmentItem> repository,
    [FromKeyedServices("lookupValues")] IReadRepository<LookupValueItem> lookupRepository,
    IUserService userService,
    ICurrentUser currentUserService)
    : IRequestHandler<SearchCapitalEquipmentsCommand, PagedList<GetCapitalEquipmentResponse>>
{
    public async Task<PagedList<GetCapitalEquipmentResponse>> Handle(SearchCapitalEquipmentsCommand request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request);
        var currentUserId = currentUserService.GetUserId();
        var canViewAll = (currentUserService.IsInRole(FshRoles.Admin) || currentUserService.IsInRole(FshRoles.FinanceAdmin));
        var spec = new SearchCapitalEquipmentSpecs(request, currentUserId, canViewAll);
        var users = await userService.GetListAsync(cancellationToken);
        var items = await repository.ListAsync(spec, cancellationToken).ConfigureAwait(false);
        var totalCount = await repository.CountAsync(spec, cancellationToken).ConfigureAwait(false);

        var lookupValues = await lookupRepository.ListAsync(cancellationToken);

        var itemsMapped = items.Select(
            x => CapitalEquipmentMapper.GetResponse(x, lookupValues, new List<FileServiceItem>(), users)
            );

        return new PagedList<GetCapitalEquipmentResponse>(itemsMapped?.ToList(), request!.PageNumber, request!.PageSize, totalCount);
    }
}

